//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a content-parametric memory reference
    /// </summary>
    public readonly struct SegRef<T> : ISegRef<SegRef<T>,T>
    {
        /// <summary>
        /// The source reference
        /// </summary>
        internal readonly SegRef Segment;

        [MethodImpl(Inline)]
        public SegRef(SegRef src)
            => Segment = src;

        [MethodImpl(Inline)]
        public SegRef(MemoryAddress address, ByteSize size)
            => Segment = new SegRef(address, size);

        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => Segment.As<T>();
        }

        public Span<byte> Buffer
        {
            [MethodImpl(Inline)]
            get => Segment.Edit;
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => Segment.Length;
        }

        public uint CellSize
        {
            [MethodImpl(Inline)]
            get => (uint)Unsafe.SizeOf<T>();
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => Length/CellSize;
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Segment.BaseAddress;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => BaseAddress == 0 || Length == 0;
        }

        [MethodImpl(Inline)]
        public unsafe ref T Cell(int index)
            => ref Unsafe.AsRef<T>((void*)(BaseAddress + (ulong)index*CellSize));

        public ref T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        [MethodImpl(Inline)]
        public Span<S> As<S>()
            => Segment.As<S>();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => Segment.Hash;
        }

        public string Format()
            => Segment.Format();

        [MethodImpl(Inline)]
        public bool Equals(SegRef<T> src)
            => Segment.Equals(src.Segment);

        public override bool Equals(object src)
            => src is SegRef<T> r && Equals(r);

        public override int GetHashCode()
            => (int)Hash;

        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static Span<T> operator !(SegRef<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator SegRef(SegRef<T> src)
            => src.Segment;

        [MethodImpl(Inline)]
        public static implicit operator SegRef<T>(SegRef src)
            => new SegRef<T>(src);

        [MethodImpl(Inline)]
        public static bool operator ==(SegRef<T> lhs, SegRef<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(SegRef<T> lhs, SegRef<T> rhs)
            => !lhs.Equals(rhs);

        public static SegRef<T> Empty
            => default;
    }
}