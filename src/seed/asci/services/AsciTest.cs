//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Konst;

    public readonly struct AsciTest
    {
        /// <summary>
        /// Tests whether a character symbol is one of '0'..'9'
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsNumeral(char c)
            => (DeciSym)c >= DeciSym.First
            && (DeciSym)c <= DeciSym.Last;         
    }
}