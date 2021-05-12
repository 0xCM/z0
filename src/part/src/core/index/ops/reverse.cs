//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    partial struct Index
    {
        [Op, Closures(Closure)]
        public static Index<T> reverse<T>(T[] src)
        {
            Array.Reverse(src);
            return src;
        }
    }
}