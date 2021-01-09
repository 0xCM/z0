//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static List<T> list<T>(params T[] src)
            => root.list<T>(src);

        [MethodImpl(Inline)]
        public static List<T> list<T>(int capacity)
            => root.list<T>(capacity);

        [MethodImpl(Inline)]
        public static List<T> list<T>(uint capacity)
            => root.list<T>(capacity);
    }
}