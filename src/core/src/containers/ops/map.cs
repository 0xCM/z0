//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    using static core;

    partial struct Index
    {
        public static Y[] map<T,Y>(T[] src, Func<T,Y> selector)
            => from x in src select selector(x);

        public static Z[] map<T,Y,Z>(T[] src, Func<T,Index<Y>> lift, Func<T,Y,Z> project)
            => array(from x in src
                            from y in lift(x).Storage
                            select project(x, y));

        public static Y[] map<T,Y>(T[] src, Func<T,Index<Y>> lift)
            => array(from x in src
                            from y in lift(x).Storage
                            select y);
    }
}
