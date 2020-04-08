//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 

    partial class BitVector
    {
        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan bitspan(BitVector4 x, int? maxbits = null)
            => BitSpan.from(x.Scalar, maxbits ?? x.Width);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan bitspan(BitVector8 x, int? maxbits = null)
            => BitSpan.from(x.Scalar, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan bitspan(BitVector16 x, int? maxbits = null)
            => BitSpan.from(x.Scalar, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan bitspan(BitVector24 x, int? maxbits = null)
            => BitSpan.from(x.Scalar, maxbits ?? x.Width);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan bitspan(BitVector32 x, int? maxbits = null)
            => BitSpan.from(x.Scalar, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan bitspan(BitVector64 x, int? maxbits = null)
            => BitSpan.from(x.Scalar, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        [MethodImpl(Inline), Op]
        public static BitSpan bitspan<T>(BitVector<T> src, int? maxbits = null)
            where T : unmanaged
                => BitSpan.from(src.Scalar, maxbits ?? 0); 

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitSpan bitspan<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitSpan.from(x.Scalar, (int)TypeNats.value<N>());
    }
}