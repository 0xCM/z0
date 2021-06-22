//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using api = SpanSorter;

    partial class XTend
    {
        public static Span<T> Sort<T>(this Span<T> src)
            where T : IComparable<T>
        {
            api.sort(src);
            return src;
        }
    }
}