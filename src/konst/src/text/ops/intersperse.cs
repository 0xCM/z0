//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static TextRules;

    partial class text
    {
        /// <summary>
        /// Creates a new string by weaving a specified character between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        [Op]
        public static string intersperse(string src, char delimiter)
            => Format.intersperse(src, delimiter);

        /// <summary>
        /// Creates a new string by weaving a substring between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="delimiter">The value to intersperse</param>
        [Op]
        public static string intersperse(string src, string delimiter)
            => Format.intersperse(src, delimiter);
    }
}