//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        /// <summary>
        /// Tests whether a character code represents <see cref='AsciChar.LF'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bit lf(C c)
            => C.LF == c;

        /// <summary>
        /// Tests whether a source character is a <see cref='AsciChar.LF'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bit lf(char c)
            => (char)C.LF == c;
    }
}