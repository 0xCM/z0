//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static TextRules;

    partial class text
    {
        [MethodImpl(Inline)]
        public static string segment(string src, int i0, int i1)
            => Parse.segment(src, i0, i1);

        [MethodImpl(Inline)]
        public static string segment(string src, uint i0, uint i1)
            => Parse.segment(src, i0, i1);
    }
}