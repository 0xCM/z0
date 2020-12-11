//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;
    using static memory;

    partial struct text
    {
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
        public static string delimit(ReadOnlySpan<string> src, string delimiter)
        {
            var count = src.Length;
            var buffer = sys.alloc<string>(count);
            var dst = span(buffer);
            var b = span(delimiter);
            for(var i=0u; i< count; i++)
                seek(dst,i) = string.Concat(skip(src,i), b);
            return string.Concat(buffer);
        }

        [MethodImpl(Inline), Op]
        public static string delimit(char delimiter, params object[] src)
            => delimit(src,delimiter);

    }
}