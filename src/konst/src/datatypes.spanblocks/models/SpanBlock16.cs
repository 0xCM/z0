//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a span of contiguous memory that can be evenly partitioned into 8 and 16-bit segments
    /// </summary>
    [Segmented(TypeWidth.W16, SpanBlockKind.Sb16)]
    public readonly ref struct SpanBlock16<T>
        where T : unmanaged
    {
        readonly Span<T> Data;

        [MethodImpl(Inline)]
        public SpanBlock16(Span<T> src)
            => Data = src;

        [MethodImpl(Inline)]
        public SpanBlock16(params T[] src)
            => Data = src;

        /// <summary>
        /// The backing storage
        /// </summary>
        public Span<T> Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// The leading storage cell
        /// </summary>
        public ref T First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        /// <summary>
        /// The number of allocated cells
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        /// <summary>
        /// The number of cells in a block
        /// </summary>
        public int BlockLength
        {
            [MethodImpl(Inline)]
            get => 2/Unsafe.SizeOf<T>();
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
            get => (ulong)CellCount * (ulong)Unsafe.SizeOf<T>()*8;
        }

        /// <summary>
        /// Mediates access to the underlying storage cells via linear index
        /// </summary>
        public ref T this[int cell]
        {
            [MethodImpl(Inline)]
            get => ref z.add(First, cell);
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
            get => Data.Bytes();
        }

        /// <summary>
        /// Mediates access to the the underlying storage cells via block index and block-relative cell index
        /// </summary>
        /// <param name="block">The block index</param>
        /// <param name="segment">The cell relative block index</param>
        [MethodImpl(Inline)]
        public ref T Cell(int block, int segment)
            => ref z.add(First, BlockLength*block + segment);

        /// <summary>
        /// Retrieves an index-identified data block
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public Span<T> Block(int block)
            => z.slice(Data, block * BlockLength, BlockLength);

        /// <summary>
        /// Extracts an index-identified block (non-allocating, but not free due to the price of creating a new wrapper)
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public SpanBlock16<T> Extract(int block)
            => new SpanBlock16<T>(Block(block));

        /// <summary>
        /// Broadcasts a value to all blocked cells
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(T src)
            => Data.Fill(src);

        /// <summary>
        /// Zero-fills all blocked cells
        /// </summary>
        [MethodImpl(Inline)]
        public void Clear()
            => Storage.Clear();

        /// <summary>
        /// Copies blocked content to a target span
        /// </summary>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void CopyTo(Span<T> dst)
            => Data.CopyTo(dst);

        /// <summary>
        /// Reinterprets the storage cell type
        /// </summary>
        /// <typeparam name="S">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public SpanBlock16<S> As<S>()
            where S : unmanaged
                => new SpanBlock16<S>(z.recover<T,S>(Data));

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => Data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref Data.GetPinnableReference();

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in SpanBlock16<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in SpanBlock16<T> src)
            => src.Data;
   }
}