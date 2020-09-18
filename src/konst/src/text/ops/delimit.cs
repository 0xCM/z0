//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string delimit<T>(T[] src, string delimiter)
        {
            var count = src.Length;
            var input = span(src);
            var buffer = sys.alloc<string>(count);
            var dst = span(buffer);
            var b = span(delimiter);
            for(var i=0u; i<count; i++)
                seek(dst,i) = format(span(skip(input,i).ToString()),b);

            return string.Concat(buffer);
        }

        [MethodImpl(Inline), Op]
        public static string delimit(char delimiter, params object[] src)
            => delimit(src,delimiter);

        [Op]
        public static string delimit(ReadOnlySpan<string> src, string delimiter)
        {
            var count = src.Length;
            var buffer = sys.alloc<string>(count);
            var dst = span(buffer);
            var b = span(delimiter);
            for(var i=0u; i< count; i++)
                seek(dst,i) = format(skip(src,i), b);
            return string.Concat(buffer);
        }

        [Op, Closures(UnsignedInts)]
        public static string delimit<T>(T[] items, char delimiter)
        {
            var dst = text.build();
            var src = @readonly(items);
            var count = src.Length;
            var sep = text.format(" {0} ", delimiter);
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    dst.Append(sep);
                dst.Append(skip(src,i));
            }
            return dst.ToString();
        }

        [Op]
        public static string nest(params object[] src)
            => text.format(RenderPatterns.SSx5,
                FieldDelimiter,
                NestedLeftFence,
                text.concat(src.Select(x => delimit(src,FieldDelimiter))),
                NestedRightFence,
                FieldDelimiter
                );

    }
}