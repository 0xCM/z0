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
        [MethodImpl(Inline)]
        public static string trim(string src)
            => Transform.trim(src);

        [MethodImpl(Inline)]
        public static string trim(string src, char match)
            => Transform.trim(src, match);
    }
}