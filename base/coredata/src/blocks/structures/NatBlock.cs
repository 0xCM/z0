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
    public readonly ref struct NatBlock<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        readonly Span<T> data;

        public static int Count => nati<N>();

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(NatBlock<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator NatBlock<N,T>(Span<T> src)
            => CheckedTransfer(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (NatBlock<N,T> src)
            => src.data;


        [MethodImpl(Inline)]
        public static implicit operator NatBlock<N,T>(Block256<T> src)
            => new NatBlock<N, T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (NatBlock<N,T> lhs, NatBlock<N,T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (NatBlock<N,T> lhs, NatBlock<N,T> rhs)
            => lhs.data != rhs.data;            
    
        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static NatBlock<N,T> CheckedTransfer(Span<T> src)
        {
            require(src.Length >= Count, $"length(src) = {src.Length} < {Count} = SpanLength");               
            return new NatBlock<N, T>(src);
        }

        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static NatBlock<N,T> CheckedTransfer(T[] src)
        {
            require(src.Length >= Count, $"length(src) = {src.Length} < {Count} = SpanLength");               
            return new NatBlock<N, T>(src);
        }

        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static NatBlock<N,T> CheckedTransfer(ReadOnlySpan<T> src)
        {
            require(src.Length >= Count, $"length(src) = {src.Length} < {Count} = SpanLength");               
            return new NatBlock<N,T>(src);
        }

        [MethodImpl(Inline)]
        internal NatBlock(T fill)
        {                    
            this.data = new Span<T>(new T[Count]);
            this.data.Fill(fill);
        }

        [MethodImpl(Inline)]
        internal NatBlock(Span<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal NatBlock(ReadOnlySpan<T> src)
            => data = src.ToArray();            

        [MethodImpl(Inline)]
        internal NatBlock(T[] src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal NatBlock(NatBlock<N,T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal NatBlock(Block256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal NatBlock(ref T src)
            => data = MemoryMarshal.CreateSpan(ref src, Count);
 
        public ref T this[int index] 
        {
            [MethodImpl(Inline)]
            get => ref data[index];
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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }

        public int Length 
        {
            [MethodImpl(Inline)]
            get => Count;
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
        public NatBlock<N,T> Replicate()        
            => new NatBlock<N,T>(data.Replicate());
                
        [MethodImpl(Inline)]
        public NatBlock<N,S> As<S>()
            where S : unmanaged
                => new NatBlock<N, S>(MemoryMarshal.Cast<T,S>(data));

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}