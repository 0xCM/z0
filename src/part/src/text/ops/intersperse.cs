//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static TextRules;
    using static Part;

    partial class text
    {
        [MethodImpl(Inline)]
        public static string intersperse(string src, char delimiter)
            => Transform.intersperse(src, delimiter);

        [MethodImpl(Inline)]
        public static string intersperse(string src, string delimiter)
            => Transform.intersperse(src, delimiter);
    }
}