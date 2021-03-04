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
        public static ReadOnlySpan<char> span(string src)
            => src;

        [MethodImpl(Inline)]
        public static string spaced(object content)
            => Format.spaced(content);

        [MethodImpl(Inline)]
        public static string spaced(char c)
            => Format.spaced(c);

        [MethodImpl(Inline)]
        public static string spaced(IEnumerable<object> items)
            => Format.spaced(items);
    }
}