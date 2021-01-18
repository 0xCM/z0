//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TextRules;

    partial class text
    {
        [Op]
        public static string remove(string src, params char[] matches)
            => Parse.remove(src,matches);
    }
}