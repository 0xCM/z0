//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Removes all occurences of a substring from the source strings where extant
        /// </summary>
        /// <param name="s">The strings to manipulate</param>
        /// <param name="substring">The substring to remove</param>
        public static IEnumerable<string> RemoveSubstring(this IEnumerable<string> src, string substring)
            => from s in src
                let r = s.Remove(substring)
                select r;
    }
}