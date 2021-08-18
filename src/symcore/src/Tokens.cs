//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct Tokens
    {
        public static ReadOnlySpan<Token> tokenize(Type symtype)
        {
            var symbols = Symbols.untyped(symtype).View;
            var symcount = symbols.Length;
            var content = text.buffer();
            for(var i=0; i< symcount; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                content.Append(symbol.Expr.Format());
                content.Append('\0');
            }

            var src = span(content.Emit());
            var count = src.Length;
            var counter = 0u;
            var tokens = span<Token>(count);
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
                        ref readonly var symbol = ref skip(symbols,k);
                        seek(tokens, counter++) = new Token(k++, symbol, text.format(slice(chars,0,t)));
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
                ref readonly var symbol = ref skip(symbols,k);
                seek(tokens, counter++) = new Token(k++, symbol, text.format(slice(chars,0,t)));
                chars.Clear();
            }
            return slice(tokens,0,counter);

        }

        public static Index<AsciCode> concat<K>(Symbols<K> src)
            where K : unmanaged
        {
            var symbols = src.View;
            var count = symbols.Length;
            var size = ByteSize.Zero;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(symbols,i);
                var id = s.Kind;
                var expr = s.Expr.Data;
                size += ((uint)expr.Length + 1);
            }

            var buffer = alloc<AsciCode>(size);
            ref var dst = ref first(buffer);
            var k=0;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(symbols,i);
                var expr = s.Expr.Data;
                for(var j=0; j<expr.Length; j++)
                    seek(dst,k++) = (AsciCode)skip(expr,j);
                seek(dst,k++) = AsciCode.Null;
            }
            return buffer;
        }

        public static ReadOnlySpan<Token<K>> tokenize<K>()
            where K : unmanaged, Enum
        {
            var symbols = Symbols.index<K>().View;
            var symcount = symbols.Length;
            var content = text.buffer();
            for(var i=0; i< symcount; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                content.Append(symbol.Expr.Format());
                content.Append('\0');
            }

            var src = span(content.Emit());
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
                        ref readonly var symbol = ref skip(symbols,k++);
                        seek(tokens, counter++) = new Token<K>(k, symbol, text.format(slice(chars,0,t)));
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
                ref readonly var symbol = ref skip(symbols,k++);
                seek(tokens, counter++) = new Token<K>(k, symbol, text.format(slice(chars,0,t)));
                chars.Clear();
            }
            return slice(tokens,0,counter);
        }
    }
}