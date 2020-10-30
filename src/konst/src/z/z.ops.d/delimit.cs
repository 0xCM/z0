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
        [MethodImpl(Inline)]
        public static DelimitedList<object> delimit(params object[] src)
            => Seq.delimited(src);

        [MethodImpl(Inline)]
        public static DelimitedList<T> delimit<T>(IList<T> src, char delimiter = FieldDelimiter)
            => Seq.delimited(src.Array(), delimiter);

        [MethodImpl(Inline)]
        public static DelimitedList<T> delimit<T>(params T[] src)
            where T : unmanaged
                => Seq.delimited(src);

        [MethodImpl(Inline)]
        public static DelimitedList<object> delimit(char delimiter, params object[] src)
                => Seq.delimited(delimiter, src);

        [MethodImpl(Inline)]
        public static DelimitedList<T> delimit<T>(char delimiter, params T[] src)
            where T : unmanaged
                => Seq.delimited(delimiter, src);
    }
}