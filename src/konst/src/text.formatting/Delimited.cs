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

    [ApiHost]
    public readonly struct Delimited
    {
        [Op]
        public static DelimitedIndex<object> list(params object[] src)
            => Seq.delimited(src);

        [Op, Closures(UnsignedInts)]
        public static DelimitedIndex<T> list<T>(IList<T> src, char delimiter = FieldDelimiter)
            => Seq.delimited(src.Array(), delimiter);

        [Op, Closures(UnsignedInts)]
        public static DelimitedIndex<T> list<T>(params T[] src)
            => Seq.delimited(src);

        [Op]
        public static DelimitedIndex<object> list(char delimiter, params object[] src)
            => Seq.delimited(delimiter, src);

        [Op, Closures(UnsignedInts)]
        public static DelimitedIndex<T> list<T>(char delimiter, params T[] src)
            => Seq.delimited(delimiter, src);
    }
}