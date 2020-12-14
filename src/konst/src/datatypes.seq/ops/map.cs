//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Seq
    {
        public static Index<Y> map<T,Y>(in Index<T> src, Func<T,Y> selector)
                => new Index<Y>(from x in src.Data select selector(x));

        public static Index<Z> map<T,Y,Z>(in Index<T> src, Func<T,Index<Y>> lift, Func<T,Y,Z> project)
            => new Index<Z>(array(from x in src.Data
                            from y in lift(x).Data
                            select project(x, y)));

        public static Index<Y> map<T,Y>(in Index<T> src, Func<T,Index<Y>> lift)
            => new Index<Y>(array(from x in src.Data
                            from y in lift(x).Data
                            select y));
    }
}