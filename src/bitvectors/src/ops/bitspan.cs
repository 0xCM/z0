//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitVector
    {
        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector4 x, int? maxbits = null)
            => BitSpans.from(x.Data, maxbits ?? x.Width);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector8 x, int? maxbits = null)
            => BitSpans.from(x.Data, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector16 x, int? maxbits = null)
            => BitSpans.from(x.Data, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector24 x, int? maxbits = null)
            => BitSpans.from(x.Data, maxbits ?? x.Width);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector32 x, int? maxbits = null)
            => BitSpans.from(x.Data, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector64 x, int? maxbits = null)
            => BitSpans.from(x.Data, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitSpan32 bitspan<T>(BitVector<T> src, int? maxbits = null)
            where T : unmanaged
                => BitSpans.from(src.Data, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitSpan32 bitspan<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitSpans.from(x.Data, (int)TypeNats.value<N>());
    }
}