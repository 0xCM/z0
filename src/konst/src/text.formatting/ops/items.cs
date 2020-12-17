//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static z;

    partial struct TextFormatter
    {
        public static ReadOnlySpan<string> items<T>(ReadOnlySpan<T> src)
        {
            var count = src.Length;
            var dst = span<string>(count);
            for(var i=0u; i<count; i++)
                seek(dst, i) = format(skip(src,i));
            return dst;
        }

        public static ReadOnlySpan<string> items<T,D>(ReadOnlySpan<T> src, D delimiter)
        {
            var sep = delimiter.ToString();
            var count = src.Length;
            var dst = span<string>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var item = ref skip(src,i);
                var itemText = format(item);
                if(i != 0)
                    seek(dst, i) = string.Format("{0}{1}", delimiter, itemText);
                else
                    seek(dst,i) = itemText;
            }
            return dst;
        }

        public static IEnumerable<string> items<F>(IEnumerable<F> items)
            => items.Select(format);
    }
}