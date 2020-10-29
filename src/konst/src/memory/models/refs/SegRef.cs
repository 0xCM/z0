//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a reference to a memory segment
    /// </summary>
    public readonly struct SegRef : ISegRef, ITextual, IEquatable<SegRef>, IHashed
    {
        public const byte Size = 16;

        readonly Vector128<ulong> Segment;


        [MethodImpl(Inline)]
        public SegRef(Vector128<ulong> src)
            => Segment = src;

        [MethodImpl(Inline)]
        public unsafe SegRef(byte* src, ByteSize length)
            =>  Segment = vparts((ulong)src, (ulong)length);

        [MethodImpl(Inline)]
        public SegRef(MemoryAddress src, ByteSize size)
            => Segment = vparts((ulong)src, (ulong)size);

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => vcell(Segment, 0);
        }

        /// <summary>
        /// Specifies the segment byte count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => (uint)vcell(Segment, 1);
        }

        public Span<byte> Buffer
        {
            [MethodImpl(Inline)]
            get => cover(Address, DataSize);
        }

        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get => new MemoryRange(Address, Address + DataSize);
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

        [MethodImpl(Inline)]
        public unsafe ref byte Cell(int offset)
            => ref @ref<byte>((void*)(Address + offset));

        public ref byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        /// <summary>
        /// Computes the whole number of T-cells covered by segment
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public int Count<T>()
            => (int)(DataSize/size<T>());

        public string Format()
            => Address.Format();

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Load()
            => view<byte>(this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Load<T>()
            => view<T>(this);

        [MethodImpl(Inline)]
        public uint Hash()
            => hash(Segment);

        [MethodImpl(Inline)]
        public bool Equals(SegRef src)
            => src.Segment.Equals(Segment);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(in SegRef src)
            => src.Segment;

        string ITextual.Format()
            => Format();

        uint IHashed.Hash
        {
            get => Hash();
        }

        bool IEquatable<SegRef>.Equals(SegRef src)
            => Equals(src);

        public override bool Equals(object src)
            => src is SegRef x && Equals(x);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash();

        public static SegRef Empty
            => default;
    }
}