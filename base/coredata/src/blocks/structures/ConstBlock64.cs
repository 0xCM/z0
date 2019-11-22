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
    /// Encapsulates a readonly span that can be evenly partitioned into 64-bit blocks
    /// </summary>
    public readonly ref struct ConstBlock64<T>
        where T : unmanaged
    {
        readonly ReadOnlySpan<T> data;

        public static N64 N => default;

        /// <summary>
        /// The number of cells per block
        /// </summary>
        public static int BlockLength => DataBlocks.blocklen<T>(N);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in ConstBlock64<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ConstBlock64<T>(in Block64<T> src)
            => new ConstBlock64<T>(src);


        [MethodImpl(Inline)]
        public static bool operator == (in ConstBlock64<T> lhs, in ConstBlock64<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in ConstBlock64<T> lhs, in ConstBlock64<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool aligned(int length)
            => Block64<T>.Aligned(length);

        [MethodImpl(Inline)]
        public static ConstBlock64<T> Load(in Block64<T> src)
            => new ConstBlock64<T>(src);

        [MethodImpl(Inline)]
        internal ConstBlock64(ReadOnlySpan<T> src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        internal ConstBlock64(in Block64<T> src)
        {
            data = src;
        }

        public ReadOnlySpan<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref readonly T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference(data);
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

        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        [MethodImpl(Inline)]
        public ref readonly T Block(int blockIndex)
            => ref  Unsafe.Add(ref Unsafe.AsRef(in Head), blockIndex*BlockLength);  

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start, int length)
            => data.Slice(start,length);

        [MethodImpl(Inline)]
        public ConstBlock64<T> SliceBlock(int blockIndex)
            => new ConstBlock64<T>(data.Slice(blockIndex * BlockLength, BlockLength));

        [MethodImpl(Inline)]
        public ConstBlock64<T> SliceBlocks(int blockIndex, int blockCount)
            => new ConstBlock64<T>(Slice(blockIndex * BlockLength, blockCount * BlockLength));
            
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
        public ConstBlock64<S> As<S>()                
            where S : unmanaged
                => new ConstBlock64<S>(MemoryMarshal.Cast<T,S>(data));                    

            
        public override string ToString() 
            => data.ToString();

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}