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
        /// Tests whether a lowercase hex symbol is a letter
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(HexSymbolLo src)
            => src >= HexSymbolLo.FirstLetter;

        /// <summary>
        /// Tests whether an uppercase hex symbol is a letter
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(HexSymbolUp src)
            => src >= HexSymbolUp.FirstLetter;
    }
}