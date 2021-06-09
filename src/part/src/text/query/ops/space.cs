//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using CC = AsciCode;

    partial struct TextQuery
    {
        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.Space'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool space(CC src)
            => src == CC.Space;

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.Space'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool space(char src)
            => space((CC)src);
    }
}