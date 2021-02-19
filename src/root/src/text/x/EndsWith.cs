//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    partial class XText
    {
        /// <summary>
        /// Determines whether a string ends with a specific character
        /// </summary>
        /// <param name="src">The string to search</param>
        /// <param name="match">The character to match</param>
        [TextUtility]
        public static bool EndsWith(this string src, char match)
            => ! string.IsNullOrWhiteSpace(src) ? src.EndsWith(match.ToString()) : false;

        /// <summary>
        /// Determines whether a string terminates with a value from a supplied set
        /// </summary>
        /// <param name="src">The string to examine</param>
        /// <param name="matches">The characters for which to search</param>
        [TextUtility]
        public static bool EndsWithAny(this string src, IEnumerable<string> matches)
        {
            foreach (var match in matches)
                if (src.EndsWith(match))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether a string ends with a digit
        /// </summary>
        /// <param name="src">The string to search</param>
        [MethodImpl(Inline), TextUtility]
        public static bool EndsWithDigit(this string src)
            => !string.IsNullOrWhiteSpace(src) ? Char.IsDigit(src.Last()) : false;
    }
}