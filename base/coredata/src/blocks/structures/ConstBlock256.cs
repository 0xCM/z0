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

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in ConstBlock256<T> xb)
            => xb.data;

        [MethodImpl(Inline)]
        public static bool operator == (in ConstBlock256<T> xb, in ConstBlock256<T> yb)
            => xb.data == yb.data;

        [MethodImpl(Inline)]
        public static bool operator != (in ConstBlock256<T> xb, in ConstBlock256<T> yb)
            => xb.data != yb.data;
                
        [MethodImpl(Inline)]
        internal ConstBlock256(in Block256<T> src)
            => data = src.Data;
        
        [MethodImpl(Inline)]
        internal ConstBlock256(ReadOnlySpan<T> src)
            => data = src;

        [MethodImpl(Inline)]
        internal ConstBlock256(Span<T> src)        
            => this.data = src;

        /// <summary>
        /// Provides access to the underlying storage
        /// </summary>
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
        public ref readonly T SeekBlock(int blockIndex)
            => ref Unsafe.Add(ref Head, blockIndex*BlockLength);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start, int length)
            => data.Slice(start,length);
            
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
        public void CopyTo(Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo(Span<T> dst)
            => data.TryCopyTo(dst);
                
        [MethodImpl(Inline)]
        public ConstBlock256<S> As<S>()                
            where S : unmanaged
                => new ConstBlock256<S>(MemoryMarshal.Cast<T,S>(data));
             
        public override string ToString() 
            => data.ToString();

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}