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
    using static Part;
    using static memory;

    /// <summary>
    /// Defines a reference to a memory segment
    /// </summary>
    public readonly struct MemorySegment : IMemorySegment, ITextual, IEquatable<MemorySegment>, IHashed
    {
        public const byte StorageSize = 16;

        readonly Vector128<ulong> Segment;

        [MethodImpl(Inline)]
        public unsafe MemorySegment(byte* src, ByteSize size)
            => Segment = Create((ulong)src, (ulong)size);

        [MethodImpl(Inline)]
        public MemorySegment(MemoryAddress src, ByteSize size)
            => Segment = Create((ulong)src, (ulong)size);

        [MethodImpl(Inline)]
        public MemorySegment(MemoryRange range)
            : this(range.Min, range.Size)
        {

        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Segment.GetElement(0);
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Segment.GetElement(1);
        }

        /// <summary>
        /// Specifies the segment byte count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public uint Length
        {
            [MethodImpl(Inline)]
            get => (uint)Segment.GetElement(1);
        }

        public Span<byte> Buffer
        {
            [MethodImpl(Inline)]
            get => memory.cover<byte>(BaseAddress, Length);
        }

        public MemoryAddress LastAddress
        {
            [MethodImpl(Inline)]
            get => BaseAddress + Length;
        }

        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get => new MemoryRange(BaseAddress, BaseAddress + Length);
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
        public bool Contains(MemoryAddress src)
            => src >= BaseAddress && src <= LastAddress;

        [MethodImpl(Inline)]
        public unsafe ref byte Cell(int offset)
            => ref memory.@ref<byte>((void*)(BaseAddress + offset));

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
        public uint CellCount<T>()
            => count<T>(this);

        public string Format()
            => Range.Format();

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Load()
            => view<byte>(this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Load<T>()
            => view<T>(this);

        [MethodImpl(Inline)]
        public uint Hash()
            => alg.hash.calc(Segment);

        [MethodImpl(Inline)]
        public bool Equals(MemorySegment src)
            => src.Segment.Equals(Segment);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(in MemorySegment src)
            => src.Segment;

        uint IHashed.Hash
            => Hash();

        bool IEquatable<MemorySegment>.Equals(MemorySegment src)
            => Equals(src);

        public override bool Equals(object src)
            => src is MemorySegment x && Equals(x);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash();

        public static MemorySegment Empty
            => default;

        [MethodImpl(Inline)]
        static uint count<T>(in MemorySegment src)
            => (uint)(src.Length/size<T>());

        [MethodImpl(Inline)]
        static ReadOnlySpan<T> view<T>(in MemorySegment src)
            => cover(src.BaseAddress.Ref<T>(), count<T>(src));
    }
}