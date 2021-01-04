//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    /// <summary>
    /// Defines a content-parametric memory reference
    /// </summary>
    public readonly struct Ref<T> : ISegRef<Ref<T>,T>
    {
        /// <summary>
        /// The source reference
        /// </summary>
        internal readonly Ref Segment;

        [MethodImpl(Inline)]
        public Ref(Ref src)
            => Segment = src;

        [MethodImpl(Inline)]
        public Ref(MemoryAddress address, ulong size)
            => Segment = new Ref(address, size);

        [MethodImpl(Inline)]
        public Ref(Vector128<ulong> src)
            => Segment = new Ref(src);

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

        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => Segment.DataSize;
        }

        public uint CellSize
        {
            [MethodImpl(Inline)]
            get => (uint)Unsafe.SizeOf<T>();
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => DataSize/CellSize;
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Segment.BaseAddress;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => BaseAddress == 0 || DataSize == 0;
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
        public bool Equals(Ref<T> src)
            => Segment.Equals(src.Segment);

        public override bool Equals(object src)
            => src is Ref<T> r && Equals(r);

        public override int GetHashCode()
            => (int)Hash;

        public static Ref<T> Empty
            => default;

        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static Span<T> operator !(Ref<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Ref(Ref<T> src)
            => src.Segment;

        [MethodImpl(Inline)]
        public static implicit operator Ref<T>(Ref src)
            => new Ref<T>(src);

        [MethodImpl(Inline)]
        public static bool operator ==(Ref<T> lhs, Ref<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Ref<T> lhs, Ref<T> rhs)
            => !lhs.Equals(rhs);
    }
}