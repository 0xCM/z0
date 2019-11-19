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
    /// Defines a span that holds a natural number of bits that is a multiple of 64
    /// </summary>
    public readonly ref struct BitSpan<T>
        where T : unmanaged
    {
        readonly Span<T> data;

        public int CellCount => data.Length;

        public int BitCount => Unsafe.SizeOf<T>() * 8 * CellCount;
        
        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in BitSpan<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (in BitSpan<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (in BitSpan<T> lhs, in BitSpan<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in BitSpan<T> lhs, in BitSpan<T> rhs)
            => lhs.data != rhs.data;            

        [MethodImpl(Inline)]
        internal BitSpan(T fill, int len)
        {                    
            this.data = new Span<T>(new T[len]);
            this.data.Fill(fill);
        }

        [MethodImpl(Inline)]
        internal BitSpan(Span<T> src)
            => this.data = src;
 
        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference(data);
        }

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
        public bool TryCopyTo (Span<T> dst)
            => data.TryCopyTo(dst);        
        
        [MethodImpl(Inline)]
        public BitSpan<T> Replicate()        
            => new BitSpan<T>(data.Replicate());
        
        public int Length 
            => BitCount;
            
        public bool IsEmpty
            => data.IsEmpty;

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();
 
        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}