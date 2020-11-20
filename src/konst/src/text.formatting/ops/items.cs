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

    using static Konst;
    using static z;

    partial struct Render
    {
        public static ReadOnlySpan<string> items<T>(ReadOnlySpan<T> src)
            where T : ITextual
        {
            var count = src.Length;
            var dst = z.span<string>(count);
            for(var i=0u; i<count; i++)
                z.seek(dst, i) = skip(src,i).Format();
            return dst;
        }

        public static ReadOnlySpan<string> items<T,D>(ReadOnlySpan<T> src, D delimiter)
            where T : ITextual
        {
            var sep = delimiter.ToString();
            var count = src.Length;
            var dst = z.span<string>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var item = ref skip(src,i);
                var itemText = item.Format();
                if(i != 0)
                    z.seek(dst, i) = string.Format("{0}{1}", delimiter, itemText);
                else
                    z.seek(dst,i) = itemText;
            }
            return dst;
        }

        public static IEnumerable<string> items<F>(IEnumerable<F> items)
            where F : ITextual
                => items.Select(m => m.Format());
    }
}