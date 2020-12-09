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
        public static string lines(params string[] src)
            => Format.lines(src);
    }
}