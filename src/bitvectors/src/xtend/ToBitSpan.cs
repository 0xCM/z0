//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static BitSpan32 ToBitSpan<N,T>(this BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.bitspan(x);

        [MethodImpl(Inline)]
        public static BitSpan32 ToBitSpan<T>(this BitVector<T> src, int? maxits = null)
            where T : unmanaged
                => BitVector.bitspan(src,maxits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan32 ToBitSpan(this BitVector4 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan32 ToBitSpan(this BitVector8 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan32 ToBitSpan(this BitVector16 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan32 ToBitSpan(this BitVector24 src, int? maxbits = null)
             => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan32 ToBitSpan(this BitVector32 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan32 ToBitSpan(this BitVector64 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);
    }
}