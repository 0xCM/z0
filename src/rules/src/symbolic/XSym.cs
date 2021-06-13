//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static SymbolicCalcs;

    public static partial class XSym
    {
        [MethodImpl(Inline), TextUtility]
        public static string TakeBefore(this string src, char match)
            => before(src, match);

        [MethodImpl(Inline), TextUtility]
        public static string TakeAfter(this string src, char match)
            => after(src,match);

        [MethodImpl(Inline), TextUtility]
        public static string TakeAfter(this string s, string match)
            => after(s,match);
    }
}