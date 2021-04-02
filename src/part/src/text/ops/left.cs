//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    partial class text
    {
        /// <summary>
        /// Returns the substring [0,chars-1]
        /// </summary>
        [Op]
        public static string left(string src, int chars)
            => Query.blank(src) ? src : text.substring(src, 0, src.Length < chars ? src.Length : chars);
    }
}