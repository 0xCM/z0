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
            => corefunc.list<T>(src);

        [MethodImpl(Inline)]
        public static List<T> list<T>(int capacity)
            => corefunc.list<T>(capacity);

        [MethodImpl(Inline)]
        public static List<T> list<T>(uint capacity)
            => corefunc.list<T>(capacity);
    }
}