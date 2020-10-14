//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct text
    {
        /// <summary>
        /// Concatenates a sequence of values with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Options), Op]
        public static string concat(IEnumerable<object> src)
            => string.Concat(src);

        /// <summary>
        /// Joins the string representation of a sequence of items interspersed by a separator
        /// </summary>
        /// <param name="sep">The value delimiter</param>
        /// <param name="src">The values to be joined</param>
        [MethodImpl(Options), Op]
        public static string concat(string sep, IEnumerable<object> src)
            => string.Join(sep, src);

        /// <summary>
        /// Concatenates a sequence of strings interspersed by a character delimiter with a space on either side
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Options), Op]
        public static string concat(char sep, IEnumerable<object> src)
            => string.Join(sep, src);
    }
}