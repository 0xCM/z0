//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {
        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan(this BitVector4 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan(this BitVector8 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan(this BitVector16 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan(this BitVector24 src, int? maxbits = null)
             => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan(this BitVector32 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);

        /// <summary>
        /// Creates the vector's bitspan representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan(this BitVector64 src, int? maxbits = null)
            => BitVector.bitspan(src,maxbits);

        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan<N,T>(this BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.bitspan(x);

        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan<T>(this BitVector<T> src, int? maxits = null)
            where T : unmanaged
                => BitVector.bitspan(src,maxits);

        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this BitSpan src, N8 n)
            => src.Extract<byte>();

        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this BitSpan src, N16 n)
            => src.Extract<ushort>();

        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this BitSpan src, N32 n)
            => src.Extract<uint>();

        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this BitSpan src, N64 n)
            => src.Extract<ulong>();

        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this BitSpan src)
            where T : unmanaged
                => src.Extract<T>();

        [MethodImpl(Inline)]
        public static BitVector<N,T> ToBitVector<N,T>(this BitSpan src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
               => src.Extract<T>();
    }
}