//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Seq
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<T> filter<T>(in Index<T> src, Func<T,bool> predicate)
            => new Index<T>(from x in src.Storage where predicate(x) select x);
    }
}