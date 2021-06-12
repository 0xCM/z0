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
        /// Determines whether an asci code defines the <see cref='Chars.Space'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool space(C src)
            => src == C.Space;

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.Space'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool space(char src)
            => space((C)src);
    }
}