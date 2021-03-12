//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    partial struct Index
    {
        public static Index<T> sort<T>(Index<T> src)
        {
            Array.Sort(src.Storage);
            return src;
        }

        public static Index<T> sort<T>(T[] src)
        {
            Array.Sort(src);
            return new Index<T>(src);
        }
    }
}