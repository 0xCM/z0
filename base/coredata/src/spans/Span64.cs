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
    /// A System.Span[T] clone where the length is always a multiple of 8 bytes = 64 bits
    /// </summary>
    public readonly ref struct Span64<T>
        where T : unmanaged
    {
        readonly Span<T> data;

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
        public static implicit operator Span<T>(in Span64<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (in Span64<T> src)
            => src.ReadOnly();

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan64<T> (in Span64<T> src)
            => ReadOnlySpan64<T>.Load(src);

        [MethodImpl(Inline)]
        public static bool operator == (in Span64<T> lhs, in Span64<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in Span64<T> lhs, in Span64<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool Aligned(int length)
            => length % BlockLength == 0;

        [MethodImpl(NotInline)]
        public static Span64<T> AllocBlocks(int count, T? fill = null)
        {
            var dst = new Span64<T>(new T[count * BlockLength]);
            if(fill != null)
                dst.data.Fill(fill.Value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span64<T> Load(T[] src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Span64<T>(src, offset, src.Length - offset);
        }

        [MethodImpl(Inline)]
        public static Span64<T> Transfer(Span<T> src)
        {
            require(Aligned(src.Length));
            return new Span64<T>(src);
        }

        [MethodImpl(Inline)]
        internal static Span64<T> TransferUnsafe(Span<T> src)
            => new Span64<T>(src);

        [MethodImpl(Inline)]
        public static Span64<T> Load(ReadOnlySpan<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Span64<T>( offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static Span64<T> Load(Span<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Span64<T>(offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static unsafe Span64<T> Load(void* src, int length)
        {
            require(Aligned(length));
            return new Span64<T>(src,length);
        }


        [MethodImpl(Inline)]
        unsafe Span64(void* src, int length)    
        {
            data = new Span<T>(src, length);  
        }

        [MethodImpl(Inline)]
        Span64(T[] src, int offset, int length)
        {
            data = new Span<T>(src, offset, length);
        }

        
        [MethodImpl(Inline)]
        Span64(ReadOnlySpan<T> src)
        {
            data = src.ToArray();            
        }

        [MethodImpl(Inline)]
        Span64(Span<T> src)
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
        public Span64<T> Blocked(int blockIndex)
        {
            var slice = data.Slice(blockIndex * BlockLength, BlockLength); 
            return new Span64<T>(slice);
        }

        [MethodImpl(Inline)]
        public Span<T> Slice(int offset)
            => data.Slice(offset);
            
        [MethodImpl(Inline)]
        public Span<T> Slice(int offset, int length)
            => data.Slice(offset,length);

        [MethodImpl(Inline)]
        public Span64<T> SliceBlock(int blockIndex)
            => new Span64<T>(data.Slice(blockIndex * BlockLength, BlockLength));
        
        [MethodImpl(Inline)]
        public Span64<T> SliceBlocks(int blockIndex, int blockCount)
            => new Span64<T>(Slice(blockIndex * BlockLength, blockCount * BlockLength ));
            
        [MethodImpl(Inline)]
        public ReadOnlySpan64<T> ReadOnly()
            => (ReadOnlySpan64<T>)data;

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
        public Span64<S> As<S>()                
            where S : unmanaged
                => Span64.load(MemoryMarshal.Cast<T,S>(data));                    

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}