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
    using static DataBlocks;

    /// <summary>
    /// Defines a span of natural length N
    /// </summary>
    public readonly ref struct NatBlock<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        internal readonly Span<T> data;

        static N n => default;
    

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in NatBlock<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator NatBlock<N,T>(Span<T> src)
            => DataBlocks.checkedload(src,n);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (in NatBlock<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator NatBlock<N,T>(in Block256<T> src)
            => new NatBlock<N, T>(src);
    
        [MethodImpl(Inline)]
        internal NatBlock(Span<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal NatBlock(in Block256<T> src)
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
            get => nati<N>();
        }

        /// <summary>
        /// Indexes directly into the underlying storage cells
        /// </summary>
        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, ix);
        }

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();
               
        [MethodImpl(Inline)]
        public NatBlock<N,S> As<S>()
            where S : unmanaged
                => new NatBlock<N, S>(MemoryMarshal.Cast<T,S>(data));
    }
}