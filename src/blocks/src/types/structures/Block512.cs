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

    /// <summary>
    /// Defines a span of contiguous memory that can be evenly partitioned into 8, 16, 32, 64, 128, 256 and 512-bit segments
    /// </summary>
    [Blocked(TypeWidth.W512, CellWidth.W512 | CellWidth.W256 | CellWidth.W128 | CellWidth.Numeric)]
    public readonly ref struct Block512<T>
        where T : unmanaged
    {
        readonly Span<T> data;        

        [MethodImpl(Inline)]
        public static explicit operator Span<T>(in Block512<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ReadOnlySpan<T>(in Block512<T> src)
            => src.data;

        [MethodImpl(Inline)]
        internal Block512(Span<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal Block512(params T[] src)
            => this.data = src;

        /// <summary>
        /// The unblocked storage cells
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
            get => ref MemoryMarshal.GetReference(data);
        }

        /// <summary>
        /// True if no capacity exists, false otherwise
        /// </summary>
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
            get => 64/Unsafe.SizeOf<T>();
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
            => ref Unsafe.Add(ref Head, BlockLength*block + segment);
            
        /// <summary>
        /// Retrieves an index-identified data block
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public Span<T> Block(int block)    
            => data.Slice(block * BlockLength, BlockLength);

        /// <summary>
        /// Extracts an index-identified block (non-allocating, but not free due to the price of creating a new wrapper)
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public Block512<T> Extract(int block)
            => new Block512<T>(Block(block));

        /// <summary>
        /// Retrieves the lower 256 bits of an index-identified block
        /// </summary>
        /// <param name="block">The block-relative index</param>
        [MethodImpl(Inline)]
        public Span<T> LoBlock(int block)
        {
            var count = BlockLength / 2;            
            return data.Slice(block*BlockLength, count);
        }

        /// <summary>
        /// Retrieves the upper 256 bits of an index-identified block
        /// </summary>
        /// <param name="block">The block-relative index</param>
        [MethodImpl(Inline)]
        public Span<T> HiBlock(int block)
        {
            var count = BlockLength / 2;
            return data.Slice(block * BlockLength + count, count);
        }

        /// <summary>
        /// Broadcasts a value to all blocked cells
        /// </summary>
        /// <param name="src">The source value</param>
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
        public Block512<S> As<S>()                
            where S : unmanaged
                => new Block512<S>(MemoryMarshal.Cast<T,S>(data)); 

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();            
    }
}