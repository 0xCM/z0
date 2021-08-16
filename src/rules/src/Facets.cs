//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct Facets
    {
        const NumericKind Closure = UnsignedInts;

        [Op]
        public static ReadOnlySpan<Facet<string>> parse(ReadOnlySpan<TextLine> src)
        {
            var count = src.Length;
            var buffer = span<Facet<string>>(count);
            ref var dst = ref first(buffer);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(src,i);
                var content = line.Content;
                var j = text.index(content, Chars.Colon);
                if(j > 0)
                {
                    var name = text.left(content, j).Trim();
                    var value = text.right(content, j).Trim();
                    seek(dst, counter++) = (name,value);
                }
            }
            return slice(buffer,0,counter);
        }
    }
}