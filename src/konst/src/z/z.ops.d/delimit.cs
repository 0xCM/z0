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

    partial struct z
    {
        [Op]
        public static DelimitedList<object> delimit(params object[] src)
            => Seq.delimited(src);

        [Op, Closures(Closure)]
        public static DelimitedList<T> delimit<T>(IList<T> src, char delimiter = FieldDelimiter)
            => Seq.delimited(src.Array(), delimiter);

        [Op, Closures(Closure)]
        public static DelimitedList<T> delimit<T>(params T[] src)
            => Seq.delimited(src);

        [Op]
        public static DelimitedList<object> delimit(char delimiter, params object[] src)
            => Seq.delimited(delimiter, src);

        [Op, Closures(Closure)]
        public static DelimitedList<T> delimit<T>(char delimiter, params T[] src)
            => Seq.delimited(delimiter, src);
    }
}