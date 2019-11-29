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
    /// Encapsulates a span that can be evenly partitioned into 32-bit blocks
    /// </summary>
    public readonly ref struct Block32<T>
        where T : unmanaged
    {
        readonly Span<T> data;

        public static N32 N => default;

        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static int BlockLength => blocklen<T>(N);

        /// <summary>
        /// The size, in bytes, of a block 
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <remarks>Should always be 8 irrespective of the cell type</remarks>
        public static int BlockSize =>  Unsafe.SizeOf<T>() * BlockLength; 

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in Block32<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (in Block32<T> src)
            => src.ReadOnly();

        [MethodImpl(Inline)]
        public static implicit operator ConstBlock32<T>(in Block32<T> src)
            => new ConstBlock32<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (in Block32<T> lhs, in Block32<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in Block32<T> lhs, in Block32<T> rhs)
            => lhs.data != rhs.data;
                    
        [MethodImpl(Inline)]
        internal Block32(Span<T> src)
        {
            this.data = src;
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
        /// Reads/Writes an index-identified cell
        /// </summary>
        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, ix);
        }

        /// <summary>
        /// The encapsulated storage
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
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
        /// The number of covered blocks
        /// </summary>
        public int BlockCount 
        {
            [MethodImpl(Inline)]
            get => data.Length / BlockLength; 
        }

        /// <summary>
        /// The bit width of a block
        /// </summary>
        public int BlockWidth => N;

        /// <summary>
        /// The number of cells per block, synonymous with block length
        /// </summary>
        public int BlockCells
        {
            [MethodImpl(Inline)]
            get => BlockLength;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }

        /// <summary>
        /// Returns the leading cell of an index-identified block
        /// </summary>
        /// <param name="index">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        [MethodImpl(Inline)]
        public ref T BlockSeek(int index)
            => ref Unsafe.Add(ref Head, index*BlockLength); 

        /// <summary>
        /// Extracts a block-relative slice
        /// </summary>
        /// <param name="offset">The block-relative offset at which to begin extraction</param>
        /// <param name="count">The number of blocks to extract</param>
        [MethodImpl(Inline)]
        public Block32<T> BlockSlice(int offset, int count)
            => new Block32<T>(data.Slice(offset*BlockLength, BlockLength * count));

        [MethodImpl(Inline)]
        public Span<T> Slice(int offset)
            => data.Slice(offset);
            
        [MethodImpl(Inline)]
        public Span<T> Slice(int offset, int length)
            => data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        [MethodImpl(Inline)]
        public void Fill(T value)
            => data.Fill(value);

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo(Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo(Span<T> dst)
            => data.TryCopyTo(dst);
                
        [MethodImpl(Inline)]
        public Block32<S> As<S>()                
            where S : unmanaged
                => DataBlocks.safeload(N,MemoryMarshal.Cast<T,S>(data));                    

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}