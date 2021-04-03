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

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static string concat(params object[] src)
            => TextFormat.concat(src);

        /// <summary>
        /// Concatenates a sequence of characters with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Inline), Op]
        public static string concat(IEnumerable<char> src)
            => TextFormat.concat(src);

        [MethodImpl(Inline), Op]
        public static string concat(ReadOnlySpan<string> src, char? delimiter)
            => TextFormat.concat(src, delimiter);

        [MethodImpl(Inline), Op]
        public static string concat(ReadOnlySpan<string> src, string delimiter)
            => TextFormat.concat(src, delimiter);
    }
}