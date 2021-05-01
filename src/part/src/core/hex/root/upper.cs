//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using X = HexDigitFacets;

    partial struct Hex
    {
        /// <summary>
        /// Determines whether a character corresponds to one of the uppercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool upper(char c)
            => (HexCode)c >= X.MinLetterCodeU && (HexCode)c <= X.MaxLetterCodeU;
    }
}