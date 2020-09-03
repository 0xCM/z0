//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct asci
    {
        /// <summary>
        /// Tests whether a byte represents an asci character
        /// </summary>
        /// <param name="src">The data to test</param>
        [MethodImpl(Inline), Op]
        public static bool valid(byte src)
            => (MaskLiterals.Msb8x8x1 & src) == 0;

        /// <summary>
        /// Tests whether the data source contains only asci data
        /// </summary>
        /// <param name="src">The data to test</param>
        [MethodImpl(Inline), Op]
        public static bool valid(ushort src)
            => (MaskLiterals.Msb16x8x1 & src) == 0;

        /// <summary>
        /// Tests whether the data source contains only asci data
        /// </summary>
        /// <param name="src">The data to test</param>
        [MethodImpl(Inline), Op]
        public static bool valid(uint src)
            => (MaskLiterals.Msb32x8x1 & src) == 0;

        /// <summary>
        /// Tests whether the data source contains only asci data
        /// </summary>
        /// <param name="src">The data to test</param>
        [MethodImpl(Inline), Op]
        public static bool valid(ulong src)
            => (MaskLiterals.Msb64x8x1 & src) == 0;
    }
}