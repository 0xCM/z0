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

    partial class XText
    {
        [MethodImpl(Inline), TextUtility]
        public static string TakeBefore(this string src, char match)
            => Parse.before(src, match);

        [MethodImpl(Inline), TextUtility]
        public static string TakeAfter(this string src, char match)
            => Parse.after(src,match);

        [MethodImpl(Inline), TextUtility]
        public static string TakeAfter(this string s, string match)
            => Parse.after(s,match);
    }
}