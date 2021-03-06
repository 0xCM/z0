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
        /// Determines whether an asci code defines the <see cref='Chars.RBrace'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool rbrace(C src)
            => src == C.RBrace;

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.RBrace'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool rbrace(char src)
            => src == (char)C.RBrace;
    }
}