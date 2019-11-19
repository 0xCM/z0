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
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;    
    using System.Diagnostics;
        
    using static zfunc;

    /// <summary>
    /// A System.Span[T] clone where the  encasulated data is always a multiple 
    /// of 16 bytes = 128 bits
    /// </summary>
    public readonly ref struct Span128<T>
        where T : unmanaged
    {
        readonly Span<T> data;

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
        public static implicit operator Span<T>(in Span128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (in Span128<T> src)
            => src.ReadOnly();

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan128<T> (in Span128<T> src)
            => ReadOnlySpan128<T>.Load(src);

        [MethodImpl(Inline)]
        public static bool operator == (in Span128<T> lhs, in Span128<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in Span128<T> lhs, in Span128<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool Aligned(int length)
            => length % BlockLength == 0;

        [MethodImpl(NotInline)]
        public static Span128<T> AllocBlocks(int count, T? fill = null)
        {
            var dst = new Span128<T>(new T[count * BlockLength]);
            if(fill != null)
                dst.data.Fill(fill.Value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span128<T> Load(T[] src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Span128<T>(src, offset, src.Length - offset);
        }

        [MethodImpl(Inline)]
        public static Span128<T> Transfer(Span<T> src)
        {
            require(Aligned(src.Length));
            return new Span128<T>(src);
        }

        [MethodImpl(Inline)]
        internal static Span128<T> TransferUnsafe(Span<T> src)
            => new Span128<T>(src);

        [MethodImpl(Inline)]
        public static Span128<T> Load(ReadOnlySpan<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Span128<T>( offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static Span128<T> Load(Span<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Span128<T>(offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static unsafe Span128<T> Load(void* src, int length)
        {
            require(Aligned(length));
            return new Span128<T>(src,length);
        }


        [MethodImpl(Inline)]
        unsafe Span128(void* src, int length)    
        {
            data = new Span<T>(src, length);  
        }

        [MethodImpl(Inline)]
        Span128(T[] src, int offset, int length)
        {
            data = new Span<T>(src, offset, length);
        }

        
        [MethodImpl(Inline)]
        Span128(ReadOnlySpan<T> src)
        {
            data = src.ToArray();            
        }

        [MethodImpl(Inline)]
        Span128(Span<T> src)
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
        public ref T Block(int blockIndex)
            => ref this[blockIndex*BlockLength];

        [MethodImpl(Inline)]
        public Span128<T> Blocked(int blockIndex)
        {
            var slice = data.Slice(blockIndex * BlockLength, BlockLength); 
            return new Span128<T>(slice);
        }

        [MethodImpl(Inline)]
        public Span<T> Slice(int offset)
            => data.Slice(offset);
            
        [MethodImpl(Inline)]
        public Span<T> Slice(int offset, int length)
            => data.Slice(offset,length);

        [MethodImpl(Inline)]
        public Span128<T> SliceBlock(int blockIndex)
            => new Span128<T>(data.Slice(blockIndex * BlockLength, BlockLength));
        
        [MethodImpl(Inline)]
        public Span128<T> SliceBlocks(int blockIndex, int blockCount)
            => new Span128<T>(Slice(blockIndex * BlockLength, blockCount * BlockLength ));
            
        [MethodImpl(Inline)]
        public ReadOnlySpan128<T> ReadOnly()
            => (ReadOnlySpan128<T>)data;

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
        public Span128<S> As<S>()                
            where S : unmanaged
                => Span128.load(MemoryMarshal.Cast<T,S>(data));                    

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}