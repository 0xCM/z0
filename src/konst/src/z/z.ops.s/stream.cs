//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static IEnumerable<T> stream<T>(T head, params T[] tail)
            => root.stream(head, tail);

        [MethodImpl(Inline)]
        public static IEnumerable<T> stream<T>(IEnumerable<T> head, IEnumerable<T> tail)
            => root.stream(head, tail);

        [MethodImpl(Inline)]
        public static IEnumerable<T> stream<T>(T head, IEnumerable<T> tail)
            => root.stream(head, tail);

        [MethodImpl(Inline)]
        public static IEnumerable<T> stream<T>(IEnumerable<T> s1, IEnumerable<T> s2, IEnumerable<T> s3)
            => root.stream(s1,s2,s3);
    }
}