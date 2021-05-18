//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using DF = DecimalSymFacet;
    using XF = HexSymFacet;

    partial struct Hex
    {
        /// <summary>
        /// Tests whether a character symbol is one of '0'..'9'
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bit number(char c)
            => (DF)c >= DF.First && (DF)c <= DF.Last;

        /// <summary>
        /// Tests whether a <see cref='HexSymLo'/> value is one of '0',...,'9'
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool number(HexSymLo src)
            => (XF)src <= XF.LastNumber;

        /// <summary>
        /// Tests whether a <see cref='HexSymUp'/> value is one of '0',...,'9'
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool number(HexSymUp src)
            => (XF)src <= XF.LastNumber;
   }
}