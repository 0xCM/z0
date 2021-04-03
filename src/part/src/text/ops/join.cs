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

    partial class text
    {
        [MethodImpl(Inline)]
        public static string join<T>(string delimiter, IEnumerable<T> src)
            => TextFormat.join(delimiter, src);

        [MethodImpl(Inline)]
        public static string join<T>(string delimiter, params T[] src)
            => TextFormat.join(delimiter, src);

        [MethodImpl(Inline)]
        public static string join<T>(char delimiter, IEnumerable<T> src)
            => TextFormat.join(delimiter, src);

        [MethodImpl(Inline)]
        public static string join<T>(char delimiter, params T[] src)
            => TextFormat.join(delimiter, src);
    }
}