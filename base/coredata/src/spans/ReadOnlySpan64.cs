//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Diagnostics;
        
    using static zfunc;

    /// <summary>
    /// A System.Span[T] clone where the length is always a multiple of 8 bytes = 64 bits
    /// </summary>
    public readonly ref struct ReadOnlySpan64<T>
        where T : unmanaged
    {
        readonly ReadOnlySpan<T> data;

        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static int BlockLength => Unsafe.SizeOf<T>() >> 3;

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
        public static implicit operator ReadOnlySpan<T>(in ReadOnlySpan64<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ReadOnlySpan64<T>(Span<T> src)
            => new ReadOnlySpan64<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator ReadOnlySpan64<T>(ReadOnlySpan<T> src)
            => new ReadOnlySpan64<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan64<T> (T[] src)
            => new ReadOnlySpan64<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (in ReadOnlySpan64<T> lhs, in ReadOnlySpan64<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in ReadOnlySpan64<T> lhs, in ReadOnlySpan64<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool aligned(int length)
            => Span64<T>.Aligned(length);

        [MethodImpl(Inline)]
        public static ReadOnlySpan64<T> Load(T[] src)
        {
            require(aligned(src.Length));
            return new ReadOnlySpan64<T>(src);
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan64<T> Load(in Span64<T> src)
            => new ReadOnlySpan64<T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan64<T> load(Span<T> src, int offset, int length)
        {
            require(aligned(length));
            return new ReadOnlySpan64<T>(src.Slice(offset, length));
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan64<T> load(ReadOnlySpan<T> src, int offset, int length)
        {
            require(aligned(length));
            return new ReadOnlySpan64<T>(src.Slice(offset, length));
        }

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan64<T> load(void* src, int length)
        {
            require(aligned(length));
            return new ReadOnlySpan64<T>(src,length);
        }

        [MethodImpl(Inline)]
        unsafe ReadOnlySpan64(void* src, int length)    
        {
            data = new ReadOnlySpan<T>(src, length);  
        }

        [MethodImpl(Inline)]
        ReadOnlySpan64(T[] src)
        {
            data = src;
        }
        
        
        [MethodImpl(Inline)]
        ReadOnlySpan64(ReadOnlySpan<T> src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        ReadOnlySpan64(in Span64<T> src)
        {
            data = src.ReadOnly();
        }

        [MethodImpl(Inline)]
        ReadOnlySpan64(Span<T> src)
        {
            this.data = src;
        }

        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        [MethodImpl(Inline)]
        public ref readonly T Block(int blockIndex)
            => ref this[blockIndex*BlockLength];

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start, int length)
            => data.Slice(start,length);

        [MethodImpl(Inline)]
        public ReadOnlySpan64<T> SliceBlock(int blockIndex)
            => new ReadOnlySpan64<T>(data.Slice(blockIndex * BlockLength, BlockLength));

        [MethodImpl(Inline)]
        public ReadOnlySpan64<T> SliceBlocks(int blockIndex, int blockCount)
            => (ReadOnlySpan64<T>)Slice(blockIndex * BlockLength, blockCount * BlockLength );
            
        [MethodImpl(Inline)]
        public Span64<T> ToSpan64()
            => Span64.load(data);

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
        public ReadOnlySpan64<S> As<S>()                
            where S : unmanaged
                => (ReadOnlySpan64<S>)MemoryMarshal.Cast<T,S>(data);                    

        /// <summary>
        /// Provides access to the underlying storage
        /// </summary>
        public ReadOnlySpan<T> Unblocked
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
            
        public override string ToString() 
            => data.ToString();

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}