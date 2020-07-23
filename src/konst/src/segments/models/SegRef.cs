//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.Vector128;

    using static Konst;

    /// <summary>
    /// Defines a reference to a memory segment
    /// </summary>
    public readonly struct SegRef : ISegRef, ITextual, IEquatable<SegRef>
    {
        readonly Vector128<ulong> Segment;        

        ulong Lo
        {
            [MethodImpl(Inline)]
            get => vcell(Segment,0);
        }

        ulong Hi
        {
            [MethodImpl(Inline)]
            get => vcell(Segment,1);
        }     
        public MemoryAddress Location
        {
            [MethodImpl(Inline)]
            get => Segment.GetElement(0);
        }

        public uint CellSize 
        {
            [MethodImpl(Inline)]
            get => 1;
        }

        public Span<byte> Buffer
        {
            [MethodImpl(Inline)]
            get => z.cover(Location, DataSize);
        }
 
        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Lo;
        }

        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get => new MemoryRange(Address, Address + Hi);
        }
        
        /// <summary>
        /// Specifies the segment byte count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public uint DataSize 
        {
            [MethodImpl(Inline)]
            get => (uint)Hi;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Segment.Equals(default);
        }      
        
        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Segment.Equals(default);
        }      

        public SegRef Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public unsafe ref T Cell<T>(int index)
            => ref Unsafe.AsRef<T>((void*)(Location + (uint)index*CellSize));

        [MethodImpl(Inline)]
        public ref byte Cell(int index)
            => ref Cell<byte>(index);

        public ref byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }


        [MethodImpl(Inline)]
        public SegRef(ulong location, uint size)
            => Segment = vparts(location, (ulong)size);

        [MethodImpl(Inline)]
        public SegRef(Vector128<ulong> src)
            => Segment = src;

        [MethodImpl(Inline)]
        public unsafe SegRef(byte* src, int length)
            =>  Segment = vparts((ulong)src, (ulong)length);

        [MethodImpl(Inline)]
        public SegRef(MemoryAddress src, int length)
            => Segment = vparts((ulong)src, (ulong)length);


        /// <summary>
        /// Computes the whole number of T-cells covered by segment
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public int Count<T>()
            => (int)(DataSize/z.size<T>());

        [MethodImpl(Inline)]
        public string Format()
            => Address.Format();
        
        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Load()
            => z.view<byte>(this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Load<T>()
            => z.view<T>(this);

        [MethodImpl(Inline)]
        public uint Hash()
            => z.hash(Lo, Hi);
        
        [MethodImpl(Inline)]
        public bool Equals(SegRef src)
            => src.Segment.Equals(Segment);
        
        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash();

 
        public static SegRef Empty 
            => new SegRef(default(Vector128<ulong>));

        /// <summary>
        /// Extracts an index-identified component from the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        static T vcell<T>(Vector128<T> src, int index)
            where T : unmanaged
                => src.GetElement(index);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        static Vector128<ulong> vparts(ulong x0, ulong x1)
            => Create(x0,x1);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(in SegRef src)
            => src.Segment;
    }
}