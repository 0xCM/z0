//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct root
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool same<T>(T a, T b)
            => EqualityComparer<T>.Default.Equals(a,b);

        [MethodImpl(Inline), Op]
        public static IndexedSeq<T> seq<T>(params T[] src)
            => new IndexedSeq<T>(src);
    }
}