//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    using static zfunc;
    using static DataBlocks;

    /// <summary>
    /// Encapsulates a readonly span that can be evenly partitioned into 256-bit blocks
    /// </summary>
    public readonly ref struct ConstBlock256<T>
        where T : unmanaged
    {
        internal readonly ReadOnlySpan<T> data;

        /// <summary>
        /// The natural block width
        /// </summary>
        public static N256 N => default;


        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in ConstBlock256<T> xb)
            => xb.data;

        [MethodImpl(Inline)]
        internal ConstBlock256(ReadOnlySpan<T> src)
            => this.data = src;

        /// <summary>
        /// The backing storage
        /// </summary>
        public ReadOnlySpan<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The leading storage cell
        /// </summary>
        public ref readonly T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference<T>(data);
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
            get => blocklen<T>(N);
        }

        /// <summary>
        /// The number of covered blocks
        /// </summary>
        public int BlockCount 
        {
            [MethodImpl(Inline)]
            get => blockcount<T>(N,CellCount);
        }
        
        /// <summary>
        /// Mediates readonly access to the the underlying storage cells via linear index
        /// </summary>
        public ref readonly T this[int index] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Unsafe.AsRef(in Head), index);
        }

        /// <summary>
        /// Mediates readonly access to the the underlying storage cells via block index and block-relative cell index
        /// </summary>
        public ref readonly T this[int block, int segment] 
        {
            [MethodImpl(Inline)]
            get => ref Cell(block, segment);
        }

        /// <summary>
        /// Mediates readonly access to the the underlying storage cells via block index and block-relative cell index
        /// </summary>
        /// <param name="block">The block index</param>
        /// <param name="segment">The cell relative block index</param>
        [MethodImpl(Inline)]
        public ref readonly T Cell(int block, int segment)
            => ref Unsafe.Add(ref Unsafe.AsRef(in Head), BlockLength*block + segment);

        /// <summary>
        /// Retrieves an index-identified data block
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Block(int block)    
            => data.Slice(block * BlockLength, BlockLength);

        /// <summary>
        /// Reinterprets the storage cell type
        /// </summary>
        /// <typeparam name="S">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public ConstBlock256<S> As<S>()                
            where S : unmanaged
                => new ConstBlock256<S>(MemoryMarshal.Cast<T,S>(data));

        [MethodImpl(Inline)]
        public ReadOnlySpan<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref readonly T GetPinnableReference()
            => ref data.GetPinnableReference();                            
    }
}