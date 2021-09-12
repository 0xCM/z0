//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    partial class XTend
    {
        public static SortedSpan<T> ToSortedSpan<T>(this T[] src)
            where T : IComparable<T>
                => new SortedSpan<T>(src.Sort());

        public static SortedIndex<T> ToSortedIndex<T>(this T[] src)
            where T : IComparable<T>
                => SortedIndex<T>.sort(src);

        public static SortedSpan<T> ToSortedSpan<T>(this Index<T> src)
            where T : IComparable<T>
                => new SortedSpan<T>(src.Sort());

        public static SortedSpan<T> ToSortedSpan<T>(this ConcurrentBag<T> src)
            where T : IComparable<T>
                => src.ToIndex().ToSortedSpan();

        public static SortedSpan<T> ToSortedSpan<T>(this Span<T> src)
            where T : IComparable<T>
                => new SortedSpan<T>(src.Sort());
    }
}