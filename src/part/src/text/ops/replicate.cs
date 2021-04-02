//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    partial class text
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> replicate(char src, int count)
            => Transform.replicate(src,count);

        [MethodImpl(Inline)]
        public static IEnumerable<string> replicate(string src, int count)
            => Transform.replicate(src,count);
    }
}