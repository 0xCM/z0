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
        public static string delimit<T>(T[] src, char delimiter)
            => text.delimit(src,$" {delimiter} ");

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
        public static string delimit<T>(T[] src)
        {
            var dst = text.build();
            dst.Append(Chars.LBracket);
            var source = @readonly(src);
            var count = source.Length;
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                {
                    dst.Append(Chars.Pipe);
                    dst.Append(Space);
                }
                dst.Append(skip(src,i));
            }
            dst.Append(Chars.RBracket);
            return dst.ToString();
        }
    }
}