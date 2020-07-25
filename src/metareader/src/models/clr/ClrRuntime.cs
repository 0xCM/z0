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

        public readonly struct DacLibrary
        {
            public CallableCOMWrapper OwningLibrary {get;}
        }        

        /// <summary>
        /// Types of CLR handles.
        /// </summary>
        public enum ClrHandleKind
        {
            /// <summary>
            /// Weak, short lived handle.
            /// </summary>
            WeakShort = 0,

            /// <summary>
            /// Weak, long lived handle.
            /// </summary>
            WeakLong = 1,

            /// <summary>
            /// Strong handle.
            /// </summary>
            Strong = 2,

            /// <summary>
            /// Strong handle, prevents relocation of target object.
            /// </summary>
            Pinned = 3,

            /// <summary>
            /// RefCounted handle (strong when the reference count is greater than 0).
            /// </summary>
            RefCounted = 5,

            /// <summary>
            /// A weak handle which may keep its "secondary" object alive if the "target" object is also alive.
            /// </summary>
            Dependent = 6,

            /// <summary>
            /// A strong, pinned handle (keeps the target object from being relocated), used for async IO operations.
            /// </summary>
            AsyncPinned = 7,

            /// <summary>
            /// Strong handle used internally for book keeping.
            /// </summary>
            SizedRef = 8,

            /// <summary>
            /// Weak WinRT handle.
            /// </summary>
            WeakWinRT = 9,
        }        

        /// <summary>
        /// Represents a CLR handle in the target process.
        /// </summary>
        public abstract class ClrHandle : IClrRoot
        {
            /// <summary>
            /// Gets the address of the handle itself.  That is, *ulong == Object.
            /// </summary>
            public abstract ulong Address { get; }

            /// <summary>
            /// Gets the Object the handle roots.
            /// </summary>
            public abstract ClrObject Object { get; }

            /// <summary>
            /// Gets the type of handle.
            /// </summary>
            public abstract ClrHandleKind HandleKind { get; }

            /// <summary>
            /// If this handle is a RefCount handle, this returns the reference count.
            /// RefCount handles with a RefCount > 0 are strong.
            /// </summary>
            public abstract uint ReferenceCount { get; }

            /// <summary>
            /// Gets the dependent handle target if this is a dependent handle.
            /// </summary>
            public abstract ClrObject Dependent { get; }

            /// <summary>
            /// Gets the AppDomain the handle resides in.
            /// </summary>
            public abstract ClrAppDomain AppDomain { get; }

            /// <summary>
            /// Gets a value indicating whether the handle is strong (roots the object).
            /// </summary>
            public bool IsStrong
            {
                get
                {
                    switch (HandleKind)
                    {
                        case ClrHandleKind.RefCounted:
                            return ReferenceCount > 0;

                        case ClrHandleKind.WeakLong:
                        case ClrHandleKind.WeakShort:
                        case ClrHandleKind.Dependent:
                        case ClrHandleKind.WeakWinRT:
                            return false;

                        default:
                            return true;
                    }
                }
            }

            public ClrRootKind RootKind => IsStrong ? (ClrRootKind)HandleKind : ClrRootKind.None;

            public bool IsInterior => false;

            /// <summary>
            /// Gets a value indicating whether the handle pins the object (doesn't allow the GC to
            /// relocate it).
            /// </summary>
            public bool IsPinned => HandleKind == ClrHandleKind.AsyncPinned || HandleKind == ClrHandleKind.Pinned;

            /// <summary>
            /// ToString override.
            /// </summary>
            /// <returns></returns>
            public override string ToString() => $"{HandleKind.GetName()} @{Address:x12} -> {Object}";
        }        

        /// <summary>
        /// Represents a single runtime in a target process or crash dump.  This serves as the primary
        /// entry point for getting diagnostic information.
        /// </summary>
        public abstract class ClrRuntime : IDisposable
        {
            /// <summary>
            /// Used for internal purposes.
            /// </summary>
            public abstract DacLibrary DacLibrary { get; }

            /// <summary>
            /// Gets the <see cref="ClrInfo"/> of the current runtime.
            /// </summary>
            public abstract ClrInfo ClrInfo { get; }

            /// <summary>
            /// Gets the <see cref="DataTarget"/> associated with this runtime.
            /// </summary>
            public abstract DataTarget? DataTarget { get; }

            /// <summary>
            /// Returns whether you are allowed to call into the transitive closure of ClrMD objects created from
            /// this runtime on multiple threads.
            /// </summary>
            public abstract bool IsThreadSafe { get; }

            /// <summary>
            /// Gets the list of appdomains in the process.
            /// </summary>
            public abstract ImmutableArray<ClrAppDomain> AppDomains { get; }

            /// <summary>
            /// Gets the System AppDomain for Desktop CLR (<see langword="null"/> on .NET Core).
            /// </summary>
            public abstract ClrAppDomain? SystemDomain { get; }

            /// <summary>
            /// Gets the Shared AppDomain for Desktop CLR (<see langword="null"/> on .NET Core).
            /// </summary>
            public abstract ClrAppDomain? SharedDomain { get; }

            public abstract ClrModule BaseClassLibrary { get; }

            /// <summary>
            /// Gets all managed threads in the process.  Only threads which have previously run managed
            /// code will be enumerated.
            /// </summary>
            public abstract ImmutableArray<ClrThread> Threads { get; }

            /// <summary>
            /// Returns a ClrMethod by its internal runtime handle (on desktop CLR this is a MethodDesc).
            /// </summary>
            /// <param name="methodHandle">The method handle (MethodDesc) to look up.</param>
            /// <returns>The ClrMethod for the given method handle, or <see langword="null"/> if no method was found.</returns>
            public abstract ClrMethod GetMethodByHandle(ulong methodHandle);

            /// <summary>
            /// Gets the <see cref="ClrType"/> corresponding to the given MethodTable.
            /// </summary>
            /// <param name="methodTable">The ClrType.MethodTable for the requested type.</param>
            /// <returns>A ClrType object, or <see langword="null"/> if no such type exists.</returns>
            public abstract ClrType GetTypeByMethodTable(ulong methodTable);

            /// <summary>
            /// Enumerates a list of GC handles currently in the process.  Note that this list may be incomplete
            /// depending on the state of the process when we attempt to walk the handle table.
            /// </summary>
            /// <returns>The list of GC handles in the process, NULL on catastrophic error.</returns>
            public abstract IEnumerable<ClrHandle> EnumerateHandles();

            /// <summary>
            /// Gets the GC heap of the process.
            /// </summary>
            public abstract ClrHeap Heap { get; }

            /// <summary>
            /// Attempts to get a ClrMethod for the given instruction pointer.  This will return NULL if the
            /// given instruction pointer is not within any managed method.
            /// </summary>
            public abstract ClrMethod GetMethodByInstructionPointer(ulong ip);

            /// <summary>
            /// Enumerate all managed modules in the runtime.
            /// </summary>
            public abstract IEnumerable<ClrModule> EnumerateModules();

            /// <summary>
            /// Flushes the DAC cache.  This function MUST be called any time you expect to call the same function
            /// but expect different results.  For example, after walking the heap, you need to call Flush before
            /// attempting to walk the heap again.  After calling this function, you must discard ALL ClrMD objects
            /// you have cached other than DataTarget and ClrRuntime and re-request the objects and data you need.
            /// (e.g. if you want to use the ClrHeap object after calling flush, you must call ClrRuntime.GetHeap
            /// again after Flush to get a new instance.)
            /// </summary>
            public abstract void FlushCachedData();

            /// <summary>
            /// Gets the name of a JIT helper function.
            /// </summary>
            /// <param name="address">Address of a possible JIT helper function.</param>
            /// <returns>The name of the JIT helper function or <see langword="null"/> if <paramref name="address"/> isn't a JIT helper function.</returns>
            public abstract string GetJitHelperFunctionName(ulong address);

            /// <summary>
            /// Cleans up all resources and releases them.  You may not use this ClrRuntime or any object it transitively
            /// created after calling this method.
            /// </summary>
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            /// <summary>
            /// Called when disposing ClrRuntime.
            /// </summary>
            /// <param name="disposing">Whether Dispose() was called or not.</param>
            protected abstract void Dispose(bool disposing);
        }        

        
    }

}