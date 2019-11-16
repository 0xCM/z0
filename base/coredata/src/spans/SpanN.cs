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

    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines a span of natural length N
    /// </summary>
    public ref struct Span<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        Span<T> data;

        public static int Count => nati<N>();

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Span<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator Span<N,T>(Span<T> src)
            => CheckedTransfer(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (Span<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<N,T>(Span<N,T> src)
            => new ReadOnlySpan<N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span<N,T>(Span256<T> src)
            => new Span<N, T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (Span<N,T> lhs, Span<N,T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (Span<N,T> lhs, Span<N,T> rhs)
            => lhs.data != rhs.data;            

        /// <summary>
        /// Uncritically assigns a source span to the state store of natural span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span<N,T> Transfer(Span<T> src)
            => new Span<N, T>(src);

        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,T> CheckedTransfer(Span<T> src)
        {
            require(src.Length >= Count, $"length(src) = {src.Length} < {Count} = SpanLength");               
            return new Span<N, T>(src);
        }

        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,T> CheckedTransfer(T[] src)
        {
            require(src.Length >= Count, $"length(src) = {src.Length} < {Count} = SpanLength");               
            return new Span<N, T>(src);
        }

        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,T> CheckedTransfer(ReadOnlySpan<T> src)
        {
            require(src.Length >= Count, $"length(src) = {src.Length} < {Count} = SpanLength");               
            return new Span<N,T>(src);
        }

        [MethodImpl(Inline)]
        internal Span(T fill)
        {                    
            this.data = new Span<T>(new T[Count]);
            this.data.Fill(fill);
        }

        [MethodImpl(Inline)]
        Span(Span<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        Span(ReadOnlySpan<T> src)
            => data = src.ToArray();            

        [MethodImpl(Inline)]
        Span(T[] src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal Span(Span<N,T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal Span(Span256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal Span(ref T src)
            => data = MemoryMarshal.CreateSpan(ref src, Count);

        [MethodImpl(Inline)]
        internal Span(ReadOnlySpan<N,T> src)
            => data = src.ToArray();
 
        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        public Span<T> Unsized
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
        public Span<N,T> Replicate()        
            => new Span<N,T>(data.Replicate());
        
        public int Length 
            => Count;
            
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