    //-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines a span predicated on a natural number N := log2(bitcount)
    /// </summary>
    public readonly ref struct BitSpan<N,T>
        where N : unmanaged, ITypeNat<N>
        where T : unmanaged
    {
        readonly Span<T> data;

        public static int BitCount => BitSpan.bits<N>();

        public static int CellCount => BitSpan.cells<N,T>();

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in BitSpan<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (in BitSpan<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (in BitSpan<N,T> lhs, in BitSpan<N,T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in BitSpan<N,T> lhs, in BitSpan<N,T> rhs)
            => lhs.data != rhs.data;            

        [MethodImpl(Inline)]
        internal BitSpan(Span<T> src)
            => this.data = src;
             
        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, ix);
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
        public void CopyTo(Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo(Span<T> dst)
            => data.TryCopyTo(dst);        
        
        [MethodImpl(Inline)]
        public BitSpan<N,T> Replicate(bool structureOnly = false)        
            => new BitSpan<N,T>(data.Replicate(structureOnly));
        
        public int Length 
            => CellCount;

        public int BitWidth
            => BitCount;            

        public bool IsEmpty
            => data.IsEmpty;

        [MethodImpl(Inline)]
        public Span<N,S> As<S>()
            where S : unmanaged
                => new Span<N, S>(MemoryMarshal.Cast<T,S>(data));

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}