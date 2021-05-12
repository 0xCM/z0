//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Index
    {
        [Op,Closures(Closure)]
        public static T[] filter<T>(T[] src, Func<T,bool> predicate)
            => from x in src where predicate(x) select x;
    }
}
