//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct Tokens
    {
        [Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<Token<K>> tokenize<K>(ReadOnlySpan<char> src)
            where K : unmanaged
        {
            var count = src.Length;
            var counter = 0u;
            var tokens = span<Token<K>>(count);
            var chars = span<char>(count);
            var k = 0u;
            var t = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                if(c == '\0')
                {
                    if(t!=0)
                    {
                        seek(tokens,counter++) = new Token<K>(@as<uint,K>(k++), text.format(slice(chars,0,t)));
                        t = 0;
                        chars.Clear();
                    }
                }
                else
                {
                    seek(chars, t++) = c;
                }
            }

            if(t!=0)
            {
                seek(tokens, counter++) = new Token<K>(@as<uint,K>(k++), text.format(slice(chars,0,t)));
                chars.Clear();
            }
            return slice(tokens,0,counter);
        }

        public static ReadOnlySpan<Token<uint>> tokenize(ReadOnlySpan<char> src)
            => tokenize<uint>(src);
    }
}