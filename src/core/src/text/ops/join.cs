//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static core;

    partial struct TextTools
    {
        public static string join(Span<string> src, string sep)
        {
            var dst = buffer();
            for(var i=0; i<src.Length; i++)
            {
                ref var cell = ref src[i];
                if(i != src.Length - 1)
                    dst.Append($"{cell}{sep}");
                else
                    dst.Append(cell);
            }
            return dst.ToString();
        }

        [Op, Closures(Closure)]
        public static string join<T>(string sep, IEnumerable<T> src)
            => string.Join(sep, src);

        [Op, Closures(Closure)]
        public static string join<T>(string sep, params T[] src)
            => string.Join(sep, src);

        [Op, Closures(Closure)]
        public static string join<T>(char sep, IEnumerable<T> src)
            => string.Join(sep, src);

        [Op, Closures(Closure)]
        public static string join<T>(string sep, ReadOnlySpan<T> src)
        {
            var dst = buffer();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    dst.Append(sep);
                dst.AppendItem(skip(src,i));
            }
            return dst.Emit();
        }

        [Op, Closures(Closure)]
        public static string join<T>(char sep, params T[] src)
            => string.Join(sep, src);
    }
}