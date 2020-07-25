//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.Win32.SafeHandles;
    using System.Collections.Immutable;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics;
    using System.Buffers;

    partial struct ClrDataModel
    {
        /// <summary>
        /// Represents a root that comes from the finalizer queue.
        /// </summary>
        public class ClrFinalizerRoot : IClrRoot
        {
            public ulong Address { get; }
            
            public ClrObject Object { get; }
            
            public ClrRootKind RootKind => ClrRootKind.FinalizerQueue;
            
            public bool IsInterior => false;
            
            public bool IsPinned => false;

            public ClrFinalizerRoot(ulong address, ClrObject obj)
            {
                Address = address;
                Object = obj;
            }

            public override string ToString() => $"finalization root @{Address:x12} -> {Object}";
        }

        /// <summary>
        /// A ClrSegment represents a contiguous region of memory that is devoted to the GC heap.
        /// Segments.  It has a start and end and knows what heap it belongs to.   Segments can
        /// optional have regions for Gen 0, 1 and 2, and Large properties.
        /// </summary>
        public abstract class ClrSegment
        {
            /// <summary>
            /// Gets the start address of the segment.  All objects in this segment fall within Start &lt;= object &lt; End.
            /// </summary>
            public abstract ulong Start { get; }

            /// <summary>
            /// Gets the end address of the segment.  All objects in this segment fall within Start &lt;= object &lt; End.
            /// </summary>
            public abstract ulong End { get; }

            /// <summary>
            /// Gets the number of bytes in the segment.
            /// </summary>
            public virtual ulong Length => End - Start;

            /// <summary>
            /// Gets the GC heap associated with this segment.  There's only one GCHeap per process, so this is
            /// only a convenience method to keep from having to pass the heap along with a segment.
            /// </summary>
            public abstract ClrHeap Heap { get; }

            /// <summary>
            /// Gets the processor that this heap is affinitized with.  In a workstation GC, there is no processor
            /// affinity (and the return value of this property is undefined).  In a server GC each segment
            /// has a logical processor in the PC associated with it.  This property returns that logical
            /// processor number (starting at 0).
            /// </summary>
            public abstract int LogicalHeap { get; }

            /// <summary>
            /// Gets the address of the end of memory reserved for the segment, but not committed.
            /// </summary>
            public abstract ulong ReservedEnd { get; }

            /// <summary>
            /// Gets the address of the end of memory committed for the segment (this may be longer than Length).
            /// </summary>
            public abstract ulong CommittedEnd { get; }

            /// <summary>
            /// Gets the first object on this segment or 0 if this segment contains no objects.
            /// </summary>
            public abstract ulong FirstObject { get; }

            /// <summary>
            /// Returns true if this is a segment for the Large Object Heap.  False otherwise.
            /// Large objects (greater than 85,000 bytes in size), are stored in their own segments and
            /// only collected on full (gen 2) collections.
            /// </summary>
            public abstract bool IsLargeObjectSegment { get; }

            /// <summary>
            /// Returns true if this segment is the ephemeral segment (meaning it contains gen0 and gen1
            /// objects).
            /// </summary>
            public abstract bool IsEphemeralSegment { get; }

            /// <summary>
            /// Ephemeral heap sements have geneation 0 and 1 in them.  Gen 1 is always above Gen 2 and
            /// Gen 0 is above Gen 1.  This property tell where Gen 0 start in memory.   Note that
            /// if this is not an Ephemeral segment, then this will return End (which makes Gen 0 empty
            /// for this segment).
            /// </summary>
            public abstract ulong Gen0Start { get; }

            /// <summary>
            /// Gets the length of the gen0 portion of this segment.
            /// </summary>
            public abstract ulong Gen0Length { get; }

            /// <summary>
            /// Gets the start of the gen1 portion of this segment.
            /// </summary>
            public abstract ulong Gen1Start { get; }

            /// <summary>
            /// Gets the length of the gen1 portion of this segment.
            /// </summary>
            public abstract ulong Gen1Length { get; }

            /// <summary>
            /// Gets the start of the gen2 portion of this segment.
            /// </summary>
            public abstract ulong Gen2Start { get; }

            /// <summary>
            /// Gets the length of the gen2 portion of this segment.
            /// </summary>
            public abstract ulong Gen2Length { get; }

            /// <summary>
            /// Enumerates all objects on the segment.
            /// </summary>
            public abstract IEnumerable<ClrObject> EnumerateObjects();

            /// <summary>
            /// Returns the generation of an object in this segment.
            /// </summary>
            /// <param name="obj">An object in this segment.</param>
            /// <returns>
            /// The generation of the given object if that object lies in this segment.  The return
            /// value is undefined if the object does not lie in this segment.
            /// </returns>
            public virtual int GetGeneration(ulong obj)
            {
                if (Gen0Start <= obj && obj < Gen0Start + Gen0Length)
                    return 0;

                if (Gen1Start <= obj && obj < Gen1Start + Gen1Length)
                    return 1;

                if (Gen2Start <= obj && obj < Gen2Start + Gen2Length)
                    return 2;

                return -1;
            }

            /// <summary>
            /// Returns a string representation of this object.
            /// </summary>
            /// <returns>A string representation of this object.</returns>
            public override string ToString()
            {
                return $"HeapSegment {Length / 1000000.0:n2}mb [{Start:X8}, {End:X8}]";
            }
        }

        /// <summary>
        /// A representation of the CLR heap.
        /// </summary>
        public abstract class ClrHeap
        {
            /// <summary>
            /// Gets the runtime associated with this heap.
            /// </summary>
            public abstract ClrRuntime Runtime { get; }

            /// <summary>
            /// Returns true if the GC heap is in a consistent state for heap enumeration.  This will return false
            /// if the process was stopped in the middle of a GC, which can cause the GC heap to be unwalkable.
            /// Note, you may still attempt to walk the heap if this function returns false, but you will likely
            /// only be able to partially walk each segment.
            /// </summary>
            public abstract bool CanWalkHeap { get; }

            public abstract int LogicalHeapCount { get; }

            /// <summary>
            /// A heap is has a list of contiguous memory regions called segments.  This list is returned in order of
            /// of increasing object addresses.
            /// </summary>
            public abstract IReadOnlyList<ClrSegment> Segments { get; }

            /// <summary>
            /// Gets the <see cref="ClrType"/> representing free space on the GC heap.
            /// </summary>
            public abstract ClrType FreeType { get; }

            /// <summary>
            /// Gets the <see cref="ClrType"/> representing <see cref="string"/>.
            /// </summary>
            public abstract ClrType StringType { get; }

            /// <summary>
            /// Gets the <see cref="ClrType"/> representing <see cref="object"/>.
            /// </summary>
            public abstract ClrType ObjectType { get; }

            /// <summary>
            /// Gets the <see cref="ClrType"/> representing <see cref="System.Exception"/>.
            /// </summary>
            public abstract ClrType ExceptionType { get; }

            /// <summary>
            /// Gets a value indicating whether the GC heap is in Server mode.
            /// </summary>
            public abstract bool IsServer { get; }

            /// <summary>
            /// Gets a <see cref="ClrObject"/> for the given address on this heap.
            /// </summary>
            /// <remarks>
            /// The returned object will have a <see langword="null"/> <see cref="ClrObject.Type"/> if objRef does not point to
            /// a valid managed object.
            /// </remarks>
            /// <param name="objRef"></param>
            /// <returns></returns>
            public ClrObject GetObject(ulong objRef) => new ClrObject(objRef, GetObjectType(objRef));

            /// <summary>
            /// Obtains the type of an object at the given address.  Returns <see langword="null"/> if objRef does not point to
            /// a valid managed object.
            /// </summary>
            public abstract ClrType GetObjectType(ulong objRef);

            /// <summary>
            /// Enumerates all objects on the heap.
            /// </summary>
            /// <returns>An enumerator for all objects on the heap.</returns>
            public abstract IEnumerable<ClrObject> EnumerateObjects();

            /// <summary>
            /// Enumerates all roots in the process.  Equivalent to the combination of:
            ///     ClrRuntime.EnumerateHandles().Where(handle => handle.IsStrong)
            ///     ClrRuntime.EnumerateThreads().SelectMany(thread => thread.EnumerateStackRoots())
            ///     ClrHeap.EnumerateFinalizerRoots()
            /// </summary>
            public abstract IEnumerable<IClrRoot> EnumerateRoots();

            /// <summary>
            /// Returns the GC segment for the given object.
            /// </summary>
            public abstract ClrSegment GetSegmentByAddress(ulong objRef);

            /// <summary>
            /// Enumerates all finalizable objects on the heap.
            /// </summary>
            public abstract IEnumerable<ClrObject> EnumerateFinalizableObjects();

            /// <summary>
            /// Enumerates all finalizable objects on the heap.
            /// </summary>
            public abstract IEnumerable<ClrFinalizerRoot> EnumerateFinalizerRoots();

            /// <summary>
            /// Returns a string representation of this heap, including the size and number of segments.
            /// </summary>
            /// <returns>The string representation of this heap.</returns>
            public override string ToString()
            {
                double sizeMb = Segments.Sum(s => (long)s.Length) / 1000000.0;
                int segCount = Segments != null ? Segments.Count : 0;
                return $"ClrHeap {sizeMb}mb {segCount} segments";
            }

            /// <summary>
            /// Use ClrObject.Size instead.
            /// </summary>
            /// <param name="objRef"></param>
            /// <param name="type"></param>
            /// <returns></returns>
            public abstract ulong GetObjectSize(ulong objRef, ClrType type);

            /// <summary>
            /// Enumerates all objects that the given object references.  This method is meant for internal use to
            /// implement ClrObject.EnumerateReferences, which you should use instead of calling this directly.
            /// </summary>
            /// <param name="obj">The object in question.</param>
            /// <param name="type">The type of the object.</param>
            /// <param name="considerDependantHandles">Whether to consider dependant handle mappings.</param>
            /// <param name="carefully">
            /// Whether to bounds check along the way (useful in cases where
            /// the heap may be in an inconsistent state.)
            /// </param>
            public abstract IEnumerable<ClrObject> EnumerateObjectReferences(ulong obj, ClrType type, bool carefully, bool considerDependantHandles);
        }

    }
}