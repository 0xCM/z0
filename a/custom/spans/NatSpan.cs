    //-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static Core;

    /// <summary>
    /// Defines a span of natural length N
    /// </summary>
    [CustomSpan("nspan")]
    public readonly ref struct NatSpan<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        internal readonly Span<T> data;

        static N n => default;    

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in NatSpan<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator NatSpan<N,T>(Span<T> src)
            => NatSpan.load(src,n);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (in NatSpan<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        internal NatSpan(Span<T> src)
            => this.data = src;

        /// <summary>
        /// The backing storage
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The leading storage cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference(data);
        }

        /// <summary>
        /// True if no capacity exist, false otherwise
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }
        
        public int Length 
        {
            [MethodImpl(Inline)]
            get => (int)value<N>();
        }

        /// <summary>
        /// Queries/manipulates an index-identified cell
        /// </summary>
        public ref T this[int index] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, index);
        }

        /// <summary>
        /// Queries/manipulates the underlying strorage through the perspective of another type
        /// </summary>
        [MethodImpl(Inline)]
        public ref S Cell<S>(int index)
            => ref Unsafe.Add(ref Unsafe.As<T,S>(ref Head), index);

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();
               
        [MethodImpl(Inline)]
        public NatSpan<N,S> As<S>()
            where S : unmanaged
                => new NatSpan<N, S>(MemoryMarshal.Cast<T,S>(data));
    }
}