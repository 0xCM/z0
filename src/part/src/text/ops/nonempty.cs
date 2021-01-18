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
        public static bool nonempty(string src)
            => Query.nonempty(src);
    }
}