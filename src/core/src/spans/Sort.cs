//-----------------------------------------------------------------------------
// Copyright   :  (c) Oleksii Nikiforov, 2020
// License     :  Unspecified
// Source:     :  https://github.com/NikiforovAll/intro-to-algorithms
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = SpanSorter;

    partial class XTend
    {
        public static Span<T> Sort<T>(this Span<T> src)
            where T : IComparable<T>
        {
            SpanSorter.sort(src);
            return src;
        }
    }

    [ApiHost]
    public readonly struct SpanSorter
    {
        [Op,Closures(UnsignedInts)]
        public static void sort<T>(Span<T> src)
            where T : IComparable<T>
         {
            var count = src.Length;
            for(var i=1; i<count; i++)
            {
                var section = slice(src,0,i+1);
                insert(section, item: skip(src,i));
            }
        }

        [MethodImpl(Inline), Op,Closures(UnsignedInts)]
        public static void insert<T>(Span<T> src, in T item)
            where T : IComparable<T>
        {
            var i = src.Length - 1;
            // shift until element is in place
            for (; i > 0 && item.CompareTo(skip(src,i - 1)) <= 0; i--)
                seek(src,i) = skip(src,i - 1);
            seek(src,i) = item;
        }
    }

    public readonly struct SpanSorter<T> : ISpanSorter<T>
        where T : IComparable<T>
    {
        public void Sort(Span<T> src)
            => api.sort(src);
    }
}