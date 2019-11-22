//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;    
        
    using static zfunc;

    /// <summary>
    /// Encapsulates a span that can be evenly partitioned into 128-bit blocks
    /// </summary>
    public readonly ref struct Block128<T>
        where T : unmanaged
    {
        readonly Span<T> data;

        public static N128 N => default;

        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static int BlockLength => Vector128<T>.Count;

        /// <summary>
        /// The size, in bytes, of a block 
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <remarks>Should always be 16 irrespective of the cell type</remarks>
        public static int BlockSize =>  Unsafe.SizeOf<T>() * BlockLength; 

        /// <summary>
        /// The size, in bytes, of a constituent block cell
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static int CellSize => BlockSize / BlockLength;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in Block128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ConstBlock128<T>(in Block128<T> src)
            => new ConstBlock128<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (in Block128<T> lhs, in Block128<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in Block128<T> lhs, in Block128<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool Aligned(int length)
            => length % BlockLength == 0;

        [MethodImpl(NotInline)]
        public static Block128<T> AllocBlocks(int count, T? fill = null)
        {
            Span<T> dst = new T[count * BlockLength];
            if(fill != null)
                dst.Fill(fill.Value);
            return new Block128<T>(dst);
        }

        [MethodImpl(NotInline)]
        public static Block128<T> Load(T[] src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            Span<T> dst = new Span<T>(src, offset, src.Length - offset);
            return new Block128<T>(dst);
        }
        
        [MethodImpl(Inline)]
        internal Block128(Span<T> src)
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
        /// The backing storage
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The encapsulated storage presented as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        /// <summary>
        /// The total number of available cells 
        /// </summary>
        public int Length 
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
        /// The number of cells per block, synonymous with block length
        /// </summary>
        public int BlockCells
        {
            [MethodImpl(Inline)]
            get => BlockLength;
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
        /// Returns the leading cell of an index-identified block
        /// </summary>
        /// <param name="blockIndex">The block index, a number in the range 0..k-1 where k is the total number of covered blocks</param>
        [MethodImpl(Inline)]
        public ref T SeekBlock(int blockIndex)
            => ref Unsafe.Add(ref Head, blockIndex*BlockLength); 

        /// <summary>
        /// Returns an index-identified block
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="blockIndex">The index of the block, with respect to 64-bit blocks</param>
        [MethodImpl(Inline)]
        public Block64<T> Block(N64 n, int blockIndex)
        {
            var count = BlockLength >> 1;
            return new Block64<T>(data.Slice(blockIndex * count, count));
        }

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
        public void CopyTo (Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo(Span<T> dst)
            => data.TryCopyTo(dst);
                
        [MethodImpl(Inline)]
        public Block128<S> As<S>()                
            where S : unmanaged
                => new Block128<S>(MemoryMarshal.Cast<T,S>(data));

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}