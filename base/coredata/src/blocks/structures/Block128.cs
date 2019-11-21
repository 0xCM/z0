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
        public static implicit operator ReadOnlySpan<T> (in Block128<T> src)
            => src.ReadOnly();

        [MethodImpl(Inline)]
        public static implicit operator ConstBlock128<T> (in Block128<T> src)
            => ConstBlock128<T>.Load(src);

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
            var dst = new Block128<T>(new T[count * BlockLength]);
            if(fill != null)
                dst.data.Fill(fill.Value);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Block128<T> Load(T[] src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Block128<T>(src, offset, src.Length - offset);
        }

        [MethodImpl(Inline)]
        internal static Block128<T> TransferUnsafe(Span<T> src)
            => new Block128<T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> Load(ReadOnlySpan<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Block128<T>( offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static Block128<T> Load(Span<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Block128<T>(offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        internal unsafe Block128(void* src, int length)    
        {
            data = new Span<T>(src, length);  
        }

        [MethodImpl(Inline)]
        internal Block128(T[] src, int offset, int length)
        {
            data = new Span<T>(src, offset, length);
        }

        
        [MethodImpl(Inline)]
        internal Block128(ReadOnlySpan<T> src)
        {
            data = src.ToArray();            
        }

        [MethodImpl(Inline)]
        internal Block128(Span<T> src)
        {
            this.data = src;
        }

        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference(data);
        }

        /// <summary>
        /// Provides access to the underlying storage
        /// </summary>
        public Span<T> Unblocked
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public int Length 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public int BlockCount 
        {
            [MethodImpl(Inline)]
            get => data.Length / BlockLength; 
        }

        public int BlockWidth
        {
            [MethodImpl(Inline)]
            get => BlockLength;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }

        [MethodImpl(Inline)]
        public ref T BlockHead(int blockIndex)
            => ref Unsafe.Add(ref Head, blockIndex*BlockLength); 

        [MethodImpl(Inline)]
        public Block128<T> Block(int blockIndex)
        {
            var slice = data.Slice(blockIndex * BlockLength, BlockLength); 
            return new Block128<T>(slice);
        }

        /// <summary>
        /// Retrieves a 64-bit block
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
        public Block128<T> SliceBlock(int blockIndex)
            => new Block128<T>(data.Slice(blockIndex * BlockLength, BlockLength));
        
        [MethodImpl(Inline)]
        public Block128<T> SliceBlocks(int blockIndex, int blockCount)
            => new Block128<T>(Slice(blockIndex * BlockLength, blockCount * BlockLength ));
            
        [MethodImpl(Inline)]
        public ConstBlock128<T> ReadOnly()
            => (ConstBlock128<T>)data;

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
                => Block128.load(MemoryMarshal.Cast<T,S>(data));                    

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}