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
        public static DelimitedList<object> delimit(params object[] src)
            => Delimited.list(src);

        public static DelimitedList<T> delimit<T>(IList<T> src, char delimiter = FieldDelimiter)
            => Delimited.list(src, delimiter);

        public static DelimitedList<T> delimit<T>(params T[] src)
            => Delimited.list(src);

        public static DelimitedList<object> delimit(char delimiter, params object[] src)
            => Delimited.list(delimiter, src);

        public static DelimitedList<T> delimit<T>(char delimiter, params T[] src)
            => Delimited.list(delimiter, src);
    }
}