//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using C = AsciCharCode;

    partial struct TextQuery
    {
        /// <summary>
        /// Determines whether an asci code defines a whitespace character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit whitespace(C src)
            => contains(AsciCodes.whitespace(), src);

        /// <summary>
        /// Determines whether a character is an asci whitespace character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit whitespace(char src)
            => whitespace((C)src);

        [MethodImpl(Inline), Op]
        public static bit whitespace2(char c)
            => space(c) || tab(c) || newline(c) || vtab(c);
    }
}