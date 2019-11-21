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
    using static MemBlocks;

    /// <summary>
    /// Encapsulates a span that can be evenly partitioned into 64-bit blocks
    /// </summary>
    public readonly ref struct Block64<T>
        where T : unmanaged
    {
        readonly Span<T> data;

        public static N64 N => default;

        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static int BlockLength => blocklen<T>(N);

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in Block64<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (in Block64<T> src)
            => src.ReadOnly();

        [MethodImpl(Inline)]
        public static implicit operator ConstBlock64<T> (in Block64<T> src)
            => src.ReadOnly();

        [MethodImpl(Inline)]
        public static bool operator == (in Block64<T> lhs, in Block64<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in Block64<T> lhs, in Block64<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool Aligned(int length)
            => length % BlockLength == 0;

        [MethodImpl(NotInline)]
        public static Block64<T> AllocBlocks(int count, T? fill = null)
        {
            var dst = new Block64<T>(new T[count * BlockLength]);
            if(fill != null)
                dst.data.Fill(fill.Value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Block64<T> Load(T[] src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Block64<T>(src, offset, src.Length - offset);
        }


        [MethodImpl(Inline)]
        internal static Block64<T> TransferUnsafe(Span<T> src)
            => new Block64<T>(src);

        [MethodImpl(Inline)]
        public static Block64<T> Load(ReadOnlySpan<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Block64<T>( offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static Block64<T> Load(Span<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return new Block64<T>(offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        internal unsafe Block64(void* src, int length)    
        {
            data = new Span<T>(src, length);  
        }

        [MethodImpl(Inline)]
        internal Block64(T[] src, int offset, int length)
        {
            data = new Span<T>(src, offset, length);
        }

        
        [MethodImpl(Inline)]
        internal Block64(ReadOnlySpan<T> src)
        {
            data = src.ToArray();            
        }

        [MethodImpl(Inline)]
        internal Block64(Span<T> src)
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
        public Block64<T> Block(int blockIndex)
            => new Block64<T>(data.Slice(blockIndex * BlockLength, BlockLength));

        [MethodImpl(Inline)]
        public Block64<T> Blocks(int blockIndex, int blockCount)
            => new Block64<T>(Slice(blockIndex * BlockLength, blockCount * BlockLength ));

        [MethodImpl(Inline)]
        public Span<T> Slice(int offset)
            => data.Slice(offset);
            
        [MethodImpl(Inline)]
        public Span<T> Slice(int offset, int length)
            => data.Slice(offset,length);
            
        [MethodImpl(Inline)]
        public ConstBlock64<T> ReadOnly()
            => ConstBlock64<T>.Load(this);

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
        public Block64<S> As<S>()                
            where S : unmanaged
                => MemBlocks.load(N,MemoryMarshal.Cast<T,S>(data));                    

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}