//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitVector
    {
        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector4 x, int? maxbits = null)
            => BitSpans32.from32(x.Data, maxbits ?? x.Width);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector8 x, int? maxbits = null)
            => BitSpans32.from32(x.Data, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector16 x, int? maxbits = null)
            => BitSpans32.from32(x.Data, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector24 x, int? maxbits = null)
            => BitSpans32.from32(x.Data, maxbits ?? x.Width);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector32 x, int? maxbits = null)
            => BitSpans32.from32(x.Data, maxbits ?? 0);

        /// <summary>
        /// Converts the vector to a bitspan representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 bitspan(BitVector64 x, int? maxbits = null)
            => BitSpans32.from32(x.Data, maxbits ?? 0);
    }
}