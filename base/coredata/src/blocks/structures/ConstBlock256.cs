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
    /// Encapsulates a readonly span that can be evenly partitioned into 256-bit blocks
    /// </summary>
    public readonly ref struct ConstBlock256<T>
        where T : unmanaged
    {
        readonly ReadOnlySpan<T> data;

        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static int BlockLength => Block256<T>.BlockLength;

        /// <summary>
        /// The size, in bytes, of a block 
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <remarks>Should always be 16 irrespective of the cell type</remarks>
        public static int BlockSize => Block256<T>.BlockSize;

        /// <summary>
        /// The size, in bytes, of a constituent block cell
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static int CellSize => Block256<T>.CellSize;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in ConstBlock256<T> xb)
            => xb.data;

        [MethodImpl(Inline)]
        public static explicit operator ConstBlock256<T>(Span<T> src)
            => new ConstBlock256<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator ConstBlock256<T>(ReadOnlySpan<T> src)
            => new ConstBlock256<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ConstBlock256<T> (T[] src)
            => new ConstBlock256<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (in ConstBlock256<T> xb, in ConstBlock256<T> yb)
            => xb.data == yb.data;

        [MethodImpl(Inline)]
        public static bool operator != (in ConstBlock256<T> xb, in ConstBlock256<T> yb)
            => xb.data != yb.data;
        
        [MethodImpl(Inline)]
        public static bool Aligned(int length)
            => Block256<T>.Aligned(length);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> Load(T[] src)
        {
            require(Aligned(src.Length));
            return new ConstBlock256<T>(src);
        }

        [MethodImpl(Inline)]
        public static ConstBlock256<T> Load(in Block256<T> src)
            => new ConstBlock256<T>(src);


        [MethodImpl(Inline)]
        public static ConstBlock256<T> Load(Span<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new ConstBlock256<T>(src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static ConstBlock256<T> Load(ReadOnlySpan<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new ConstBlock256<T>(src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static unsafe ConstBlock256<T> Load(void* src, int length)
        {
            require(Aligned(length));
            return new ConstBlock256<T>(src,length);
        }


        [MethodImpl(Inline)]
        unsafe ConstBlock256(void* src, int length)    
        {
            data = new ReadOnlySpan<T>(src, length);  
        }

        [MethodImpl(Inline)]
        ConstBlock256(T[] src)
            => data = src;
        
        
        [MethodImpl(Inline)]
        ConstBlock256(ReadOnlySpan<T> src)
            => data = src;

        [MethodImpl(Inline)]
        ConstBlock256(Span<T> src)        
            => this.data = src;

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
        public ConstBlock256<T> SliceBlock(int blockIndex)
            => new ConstBlock256<T>(data.Slice(blockIndex * BlockLength, BlockLength));
        
        [MethodImpl(Inline)]
        public ConstBlock256<T> SliceBlocks(int blockIndex, int blockCount)
            => (ConstBlock256<T>)Slice(blockIndex * BlockLength, blockCount * BlockLength );
            


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
        public ConstBlock256<S> As<S>()                
            where S : unmanaged
                => (ConstBlock256<S>)MemoryMarshal.Cast<T,S>(data);                     
             
        public override string ToString() 
            => data.ToString();

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}