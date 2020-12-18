//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public static class XSeq
    {
        public static DelimitedIndex<T> Delimit<T>(this ReadOnlySpan<T> src, char delimiter = FieldDelimiter)
            => Seq.delimit(src, delimiter);

        public static DelimitedIndex<T> Delimit<T>(this Span<T> src, char delimiter = FieldDelimiter)
            => Seq.delimit(src, delimiter);
    }
}