//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Chars;

    partial struct text
    {
        /// <summary>
        /// Produces a line of content
        /// </summary>
        /// <param name="src">The line content</param>
        [MethodImpl(Options), Op]
        public static string line(string src)
            => src + Eol;

        /// <summary>
        /// Renders each item from a sequence as list of values, delimited by end-of-line
        /// </summary>
        /// <param name="src">The content to enclose</param>
        [MethodImpl(Options), Op]
        public static string line(IEnumerable<object> src)
            => string.Join(Chars.Eol, src);
    }
}