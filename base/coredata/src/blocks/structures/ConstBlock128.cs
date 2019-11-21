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

    /// <summary>
    /// Encapsulates a readonly span that can be evenly partitioned into 128-bit blocks
    /// </summary>
    public readonly ref struct ConstBlock128<T>
        where T : unmanaged
    {
        readonly ReadOnlySpan<T> data;

        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static int BlockLength => Block128<T>.BlockLength;

        /// <summary>
        /// The size, in bytes, of a block 
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <remarks>Should always be 16 irrespective of the cell type</remarks>
        public static int BlockSize => Block128<T>.BlockSize;

        /// <summary>
        /// The size, in bytes, of a constituent block cell
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static int CellSize => Block128<T>.CellSize;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in ConstBlock128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ConstBlock128<T>(Span<T> src)
            => new ConstBlock128<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator ConstBlock128<T>(ReadOnlySpan<T> src)
            => new ConstBlock128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ConstBlock128<T> (T[] src)
            => new ConstBlock128<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (in ConstBlock128<T> lhs, in ConstBlock128<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in ConstBlock128<T> lhs, in ConstBlock128<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool aligned(int length)
            => Block128<T>.Aligned(length);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> Load(T[] src)
        {
            require(aligned(src.Length));
            return new ConstBlock128<T>(src);
        }

        [MethodImpl(Inline)]
        public static ConstBlock128<T> Load(in Block128<T> src)
            => new ConstBlock128<T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> load(Span<T> src, int offset, int length)
        {
            require(aligned(length));
            return new ConstBlock128<T>(src.Slice(offset, length));
        }

        [MethodImpl(Inline)]
        public static ConstBlock128<T> load(ReadOnlySpan<T> src, int offset, int length)
        {
            require(aligned(length));
            return new ConstBlock128<T>(src.Slice(offset, length));
        }

        [MethodImpl(Inline)]
        public static unsafe ConstBlock128<T> load(void* src, int length)
        {
            require(aligned(length));
            return new ConstBlock128<T>(src,length);
        }

        [MethodImpl(Inline)]
        internal unsafe ConstBlock128(void* src, int length)    
        {
            data = new ReadOnlySpan<T>(src, length);  
        }

        [MethodImpl(Inline)]
        internal ConstBlock128(T[] src)
        {
            data = src;
        }
        
        
        [MethodImpl(Inline)]
        internal ConstBlock128(ReadOnlySpan<T> src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        internal ConstBlock128(in Block128<T> src)
        {
            data = src.ReadOnly();
        }

        [MethodImpl(Inline)]
        internal ConstBlock128(Span<T> src)
        {
            this.data = src;
        }

        public ReadOnlySpan<T> Data
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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }
            
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference<T>(data);
        }            

        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, ix);
        }

        [MethodImpl(Inline)]
        public ref readonly T Block(int blockIndex)
            => ref Unsafe.Add(ref Head, blockIndex*BlockLength);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start, int length)
            => data.Slice(start,length);

        [MethodImpl(Inline)]
        public ConstBlock128<T> SliceBlock(int blockIndex)
            => new ConstBlock128<T>(data.Slice(blockIndex * BlockLength, BlockLength));

        [MethodImpl(Inline)]
        public ConstBlock128<T> SliceBlocks(int blockIndex, int blockCount)
            => (ConstBlock128<T>)Slice(blockIndex * BlockLength, blockCount * BlockLength );
            
        [MethodImpl(Inline)]
        public Block128<T> ToSpan128()
            => Block128.load(data);

        [MethodImpl(Inline)]
        public Span<T> ToSpan()
            => new Span<T>(data.ToArray());

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        [MethodImpl(Inline)]
        public ReadOnlySpan<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref readonly T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo (Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo (Span<T> dst)
            => data.TryCopyTo(dst);
                
        [MethodImpl(Inline)]
        public ConstBlock128<S> As<S>()                
            where S : unmanaged
                => (ConstBlock128<S>)MemoryMarshal.Cast<T,S>(data);                    
 
        public override string ToString() 
            => data.ToString();

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}