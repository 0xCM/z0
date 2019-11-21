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
    /// Defines a readonly span of natural length N
    /// </summary>
    public readonly ref struct ConstNatBlock<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        readonly ReadOnlySpan<T> data;

        public static int Count => nati<N>();

        /// <summary>
        /// Uncritically assigns a source span to the state store of natural span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstNatBlock<N,U> Transfer<U>(ReadOnlySpan<U> src)
            where U : unmanaged
                => new ConstNatBlock<N, U>(src);

        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ConstNatBlock<N,U> CheckedTransfer<U>(ReadOnlySpan<U> src)
            where U : unmanaged
        {
            
            require(src.Length >= Count, $"length(src) = {src.Length} < {Count} = SpanLength");               
            return new ConstNatBlock<N, U>(src);
        }

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (ConstNatBlock<N,T> src)
            => src.data;
    
        [MethodImpl(Inline)]
        public static implicit operator ConstNatBlock<N,T> (T[] src)
            => CheckedTransfer<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ConstNatBlock<N,T> (ReadOnlySpan<T> src)
            => CheckedTransfer<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (ConstNatBlock<N,T> lhs, ConstNatBlock<N,T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (ConstNatBlock<N,T> lhs, ConstNatBlock<N,T> rhs)
            => lhs.data != rhs.data;

        [MethodImpl(Inline)]
        internal ConstNatBlock(ref T src)
            => data = MemoryMarshal.CreateReadOnlySpan(ref src, Count);

        [MethodImpl(Inline)]
        internal ConstNatBlock(NatBlock<N,T> src)
            => this.data = src;


        [MethodImpl(Inline)]
        internal ConstNatBlock(ReadOnlySpan<T> src)
            => this.data = src;

        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        /// <summary>
        /// Provides access to the underlying storage
        /// </summary>
        public ReadOnlySpan<T> Unsized
        {
            [MethodImpl(Inline)]
            get =>  data;
        }

        public ref readonly T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference(data);
        }


        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        /// <summary>
        /// Returns the represented content modulo type-level size information
        /// </summary>
        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Unsize()
            => data;

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
        public ConstNatBlock<N,S> As<S>()
            where S : unmanaged
                => Transfer(MemoryMarshal.Cast<T,S>(data));
 
        public int Length 
            => Count;
            
        public bool IsEmpty
            => data.IsEmpty;

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}