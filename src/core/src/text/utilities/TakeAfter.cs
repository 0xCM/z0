//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XText
    {
        [MethodImpl(Inline), TextUtility]
        public static string TakeAfter(this string src, char match)
            => TextTools.after(src,match);

        [MethodImpl(Inline), TextUtility]
        public static string TakeAfter(this string s, string match)
            => TextTools.after(s,match);
    }
}