//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
        /// <summary>
        /// Tests whether a lowercase hex symbol is a numeral
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool numeral(HexDigitSymbolLo src)
            => src <= HexDigitSymbolLo.LastNumeral;

        /// <summary>
        /// Tests whether a uppercas hex symbol is a numeral
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool numeral(HexDigitSymbolUp src)
            => src <= HexDigitSymbolUp.LastNumeral;
    }
}