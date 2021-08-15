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

    using SQ = SymbolicQuery;


    [ApiHost]
    public readonly struct Facets
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static Facet<K,V> facet<K,V>(K key, V value)
            => new Facet<K,V>(key,value);

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
                var j = SQ.index(content, Chars.Colon);
                if(j > 0)
                {
                    var name = SQ.left(content, j).Format().Trim();
                    var value = SQ.right(content, j).Format().Trim();
                    seek(dst, counter++) = (name,value);
                }
            }
            return slice(buffer,0,counter);
        }
    }
}