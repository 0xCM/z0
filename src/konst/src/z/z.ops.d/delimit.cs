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
        public static DelimitedIndex<T> delimit<T>(params T[] src)
            => Seq.delimited(src);

        public static DelimitedIndex<object> delimit(char delimiter, params object[] src)
            => Seq.delimited(delimiter, src);

        public static DelimitedIndex<T> delimit<T>(char delimiter, params T[] src)
            => Seq.delimited(delimiter, src);
    }
}