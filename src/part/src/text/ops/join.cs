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
        public static string join<T>(string delimiter, IEnumerable<T> src)
            => Format.join(delimiter, src);

        [MethodImpl(Inline)]
        public static string join<T>(string delimiter, params T[] src)
            => Format.join(delimiter, src);

        [MethodImpl(Inline)]
        public static string join<T>(char delimiter, IEnumerable<T> src)
            => Format.join(delimiter,src);

        [MethodImpl(Inline)]
        public static string join<T>(char delimiter, params T[] src)
            => Format.join(delimiter,src);
    }
}