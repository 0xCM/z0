//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static TextRules;

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static string concat(params object[] src)
            => Format.concat(src);

        /// <summary>
        /// Concatenates a sequence of characters with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Inline), Op]
        public static string concat(IEnumerable<char> src)
            => Format.concat(src);

        [MethodImpl(Inline), Op]
        public static string concat(ReadOnlySpan<string> src, char? delimiter)
            => Format.concat(src, delimiter);

        [MethodImpl(Inline), Op]
        public static string concat(ReadOnlySpan<string> src, string delimiter)
            => Format.concat(src, delimiter);
    }
}