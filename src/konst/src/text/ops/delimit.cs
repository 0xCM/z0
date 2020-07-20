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
        public static string delimit<T>(T[] src, string delimiter)
            where T : ITextual
        {
            var count = src.Length;
            var input = span(src);
            var buffer = sys.alloc<string>(count);
            var dst = span(buffer);
            var b = span(delimiter);

            for(var i=0u; i< count; i++)
                seek(dst,i) = format(span(skip(input,i).Format()),b);

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
    }
}