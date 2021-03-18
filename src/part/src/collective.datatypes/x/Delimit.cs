//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XCollective
    {
        public static DelimitedIndex<T> Delimit<T>(this ReadOnlySpan<T> src, char delimiter = FieldDelimiter)
            => Seq.delimit(src, delimiter);

        public static DelimitedIndex<T> Delimit<T>(this Span<T> src, char delimiter = FieldDelimiter)
            => Seq.delimit(src, delimiter);
    }
}