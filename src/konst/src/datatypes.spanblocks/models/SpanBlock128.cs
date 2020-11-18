//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a span of contiguous memory that can be evenly partitioned into 8, 16, 32, 64 and 128-bit segments
    /// </summary>
    [ApiType(ApiTypeId.SpanBlock), Blocked(TypeWidth.W128, SpanBlockKind.Sb128)]
    public readonly ref struct SpanBlock128<T>
        where T : unmanaged
    {
        readonly Span<T> Storage;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in SpanBlock128<T> src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in SpanBlock128<T> src)
            => src.Storage;

        [MethodImpl(Inline)]
        public SpanBlock128(Span<T> src)
            => Storage = src;

        [MethodImpl(Inline)]
        public SpanBlock128(params T[] src)
            => Storage = src;

        /// <summary>
        /// The backing storage
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        /// <summary>
        /// The leading storage cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref first(Storage);
        }

        /// <summary>
        /// True if no capacity exists, false otherwise
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Storage.IsEmpty;
        }

        /// <summary>
        /// The number of allocated cells
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }

        /// <summary>
        /// The number of cells in a block
        /// </summary>
        public int BlockLength
        {
            [MethodImpl(Inline)]
            get => 16/size<T>(w32i);
        }

        /// <summary>
        /// The number of covered blocks
        /// </summary>
        public int BlockCount
        {
            [MethodImpl(Inline)]
            get => CellCount/BlockLength;
        }

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public ulong BitCount
        {
            [MethodImpl(Inline)]
            get => (ulong)CellCount * size<T>(w64)*8;
        }

        /// <summary>
        /// Mediates access to the underlying storage cells via linear index
        /// </summary>
        public ref T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, index);
        }

        /// <summary>
        /// Mediates access to the the underlying storage cells via block index and block-relative cell index
        /// </summary>
        public ref T this[int block, int segment]
        {
            [MethodImpl(Inline)]
            get => ref Cell(block, segment);
        }

        /// <summary>
        /// Presents the source data as bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Storage.Bytes();
        }

        /// <summary>
        /// Mediates access to the the underlying storage cells via block index and block-relative cell index
        /// </summary>
        /// <param name="block">The block index</param>
        /// <param name="segment">The cell relative block index</param>
        [MethodImpl(Inline)]
        public ref T Cell(int block, int segment)
            => ref Unsafe.Add(ref Head, BlockLength*block + segment);

        /// <summary>
        /// Retrieves an index-identified data block
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public Span<T> Block(int block)
            => Storage.Slice(block * BlockLength, BlockLength);

        /// <summary>
        /// Extracts an index-identified block (non-allocating, but not free due to the price of creating a new wrapper)
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public SpanBlock128<T> Extract(int block)
            => new SpanBlock128<T>(Block(block));

        /// <summary>
        /// Broadcasts a value to all blocked cells
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(T src)
            => Storage.Fill(src);

        /// <summary>
        /// Zero-fills all blocked cells
        /// </summary>
        [MethodImpl(Inline)]
        public void Clear()
            => Data.Clear();

        /// <summary>
        /// Copies blocked content to a target span
        /// </summary>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void CopyTo(Span<T> dst)
            => Storage.CopyTo(dst);

        /// <summary>
        /// Reinterprets the storage cell type
        /// </summary>
        /// <typeparam name="S">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public SpanBlock128<S> As<S>()
            where S : unmanaged
                => new SpanBlock128<S>(z.recover<T,S>(Storage));

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => Storage.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref Storage.GetPinnableReference();
    }
}