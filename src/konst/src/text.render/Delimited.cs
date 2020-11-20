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
        public static DelimitedList<object> list(params object[] src)
            => Seq.delimited(src);

        [Op, Closures(UnsignedInts)]
        public static DelimitedList<T> list<T>(IList<T> src, char delimiter = FieldDelimiter)
            => Seq.delimited(src.Array(), delimiter);

        [Op, Closures(UnsignedInts)]
        public static DelimitedList<T> list<T>(params T[] src)
            => Seq.delimited(src);

        [Op]
        public static DelimitedList<object> list(char delimiter, params object[] src)
            => Seq.delimited(delimiter, src);

        [Op, Closures(UnsignedInts)]
        public static DelimitedList<T> list<T>(char delimiter, params T[] src)
            => Seq.delimited(delimiter, src);
    }
}