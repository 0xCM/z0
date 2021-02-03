//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    [ApiHost]
    public readonly partial struct Index
    {
        const NumericKind Closure = UInt64k;

        [Op, Closures(Closure)]
        public static Index<T> reverse<T>(T[] src)
        {
            Array.Reverse(src);
            return src;
        }

        [Op, Closures(Closure)]
        public static HashIndex<T> hash<T>(Index<T> src)
            => new HashIndex<T>(src);
    }
}