//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static Konst;
    using static z;

    /// <summary>
    /// Defines a span of contiguous memory that can be evenly partitioned into 8, 16 and 32-bit segments
    /// </summary>
    [Blocked(TypeWidth.W32, CellWidth.W8 | CellWidth.W16 | CellWidth.W32)]
    public readonly ref struct Block32<T>
        where T : unmanaged
    {
        readonly Span<T> data;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in Block32<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in Block32<T> src)
            => src.data;
                    
        [MethodImpl(Inline)]
        public Block32(Span<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public Block32(params T[] src)
            => this.data = src;

        /// <summary>
        /// The backing storage
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The leading storage cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref first(data);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }

        /// <summary>
        /// The number of allocated cells
        /// </summary>
        public int CellCount 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        /// <summary>
        /// The number of cells in a block
        /// </summary>
        public int BlockLength 
        {
            [MethodImpl(Inline)]
            get => 4/(int)z.size<T>();
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
            get => (ulong)CellCount * z.bitsize<T>();
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
            get => data.Bytes();
        }

        /// <summary>
        /// Mediates access to the the underlying storage cells via block index and block-relative cell index
        /// </summary>
        /// <param name="block">The block index</param>
        /// <param name="segment">The cell relative block index</param>
        [MethodImpl(Inline)]
        public ref T Cell(int block, int segment)
            => ref add(Head, BlockLength*block + segment);

        /// <summary>
        /// Retrieves an index-identified data block
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public Span<T> Block(int block)    
            => slice(data, block * BlockLength,BlockLength);

        /// <summary>
        /// Extracts an index-identified block (non-allocating, but not free due to the price of creating a new wrapper)
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public Block32<T> Extract(int block)
            => new Block32<T>(Block(block));

        [MethodImpl(Inline)]
        public void Fill(T src)
            => data.Fill(src);

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
            => data.CopyTo(dst);

        /// <summary>
        /// Reinterprets the storage cell type
        /// </summary>
        /// <typeparam name="S">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public Block32<S> As<S>()                
            where S : unmanaged
                => new Block32<S>(z.recover<T,S>(data));                    

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();
   }
}