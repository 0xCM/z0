//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    /// Encapsulates a readonly span that can be evenly partitioned into 128-bit blocks
    /// </summary>
    public readonly ref struct ConstBlock128<T>
        where T : unmanaged
    {
        readonly ReadOnlySpan<T> data;

        /// <summary>
        /// The natural block width
        /// </summary>
        public static N128 N => default;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in ConstBlock128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        internal ConstBlock128(ReadOnlySpan<T> src)
            => this.data = src;
        
        /// <summary>
        /// The unblocked storage cells
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

        /// <summary>
        /// The number of allocated cells
        /// </summary>
        public int CellCount 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        /// <summary>
        /// The number of allocated bits
        /// </summary>
        public int BitCount 
        {
            [MethodImpl(Inline)]
            get => bitcount<T>(CellCount);
        }

        /// <summary>
        /// The number of allocated bytes
        /// </summary>
        public int ByteCount 
        {
            [MethodImpl(Inline)]
            get => bytecount<T>(CellCount);
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
        /// The number of cells in a block
        /// </summary>
        public int BlockLength
        {
            [MethodImpl(Inline)]
            get => blocklen<T>(N);
        }

        /// <summary>
        /// The bit width of a block
        /// </summary>
        public int BlockWidth => N;

        /// <summary>
        /// The bit width of a cell
        /// </summary>
        public int CellWidth 
        {
            [MethodImpl(Inline)]
            get => cellwidth<T>();
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }
            

        /// <summary>
        /// Indexes directly into the underlying storage cells
        /// </summary>
        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref MemoryMarshal.GetReference<T>(data), ix);
        }

        [MethodImpl(Inline)]
        public ConstBlock128<S> As<S>()                
            where S : unmanaged
                => new ConstBlock128<S>(MemoryMarshal.Cast<T,S>(data));                    

        [MethodImpl(Inline)]
        public ReadOnlySpan<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref readonly T GetPinnableReference()
            => ref data.GetPinnableReference();                 
   }
}