//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Typed;

    partial class dvec
    {
        /// <summary>
        /// Effects the reversal of the byte-level representation of each component in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vbyteswap(Vector128<ushort> x)
            => z.vshuf16x8(x, VKonst.vbyteswap(n128,n16));

        /// <summary>
        /// Effects the reversal of the byte-level representation of each component in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vbyteswap(Vector128<uint> x)
            => z.vshuf16x8(x, VKonst.vbyteswap(n128,n32));

        /// <summary>
        /// Effects the reversal of the byte-level representation of each component in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vbyteswap(Vector128<ulong> x)
            => z.vshuf16x8(x, VKonst.vbyteswap(n128,n64));

        /// <summary>
        /// Effects the reversal of the byte-level representation of each component in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vbyteswap(Vector256<ushort> x)
            => z.vshuf16x8(x, VKonst.vbyteswap(n256,n16));

        /// <summary>
        /// Effects the reversal of the byte-level representation of each component in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vbyteswap(Vector256<uint> x)
            => z.vshuf16x8(x, VKonst.vbyteswap(n256,n32));

        /// <summary>
        /// Effects the reversal of the byte-level representation of each component in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vbyteswap(Vector256<ulong> x)
            => z.vshuf16x8(x, VKonst.vbyteswap(n256,n64));
    }
}