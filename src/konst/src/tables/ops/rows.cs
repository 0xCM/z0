//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial struct Table
    {
        public static ReadOnlySpan<string> rows<T>(params T[] src)
            where T : struct, ITabular
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var dst = span<string>(count);
            var input = @readonly(src);
            for(var i=0u; i<count; i++)
            {
                seek(dst, i) = skip(input,i).DelimitedText(FieldDelimiter);
            }
            return dst;
        }
    }
}