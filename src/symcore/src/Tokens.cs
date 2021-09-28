//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct Tokens
    {
        [Op]
        public static ReadOnlySpan<TokenSpec> specs(ReadOnlySpan<Type> src)
        {
            var dst = list<TokenSpec>();
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var type = ref skip(src,i);
                var symbols = Symbols.untyped(type).View;
                for(var j=0; j<symbols.Length; j++)
                {
                    ref readonly var symbol = ref skip(symbols,j);
                    var record = new TokenSpec();
                    record.TokenType = type.Name;
                    record.Index = counter++;
                    record.Value = symbol.Value;
                    record.Name = symbol.Name;
                    record.Expr = symbol.Expr;
                    record.Description = symbol.Description;
                    dst.Add(record);
                }
            }
            return dst.ViewDeposited();
        }

        [Op]
        public static ReadOnlySpan<TokenSpec> specs(Type src)
        {
            var symbols = Symbols.untyped(src).View;
            var count = symbols.Length;
            var buffer = alloc<TokenSpec>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                ref var record = ref seek(dst,i);
                record.TokenType = src.Name;
                record.Index = i;
                record.Value = symbol.Value;
                record.Name =  symbol.Name;
                record.Expr = symbol.Expr;
                record.Description = symbol.Description;
            }
            return buffer;
        }

        public static ReadOnlySpan<TokenSpec> rows<E>()
            where E : unmanaged, Enum
                => specs(typeof(E));

        public static Index<char> concat<K>(Symbols<K> src)
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

            var buffer = alloc<char>(size);
            ref var dst = ref first(buffer);
            var k=0;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(symbols,i);
                var expr = s.Expr.Data;
                for(var j=0; j<expr.Length; j++)
                    seek(dst,k++) = (char)skip(expr,j);
                seek(dst,k++) = (char)0;
            }
            return buffer;
        }

        public static ReadOnlySpan<Token> tokenize(Type symtype, out ReadOnlySpan<byte> data)
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
            data = recover<byte>(src);
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
                        seek(tokens, counter++) = new Token(k++, symbol, text.format(slice(chars, 0, t)));
                        t = 0;
                        chars.Clear();
                    }
                }
                else
                    seek(chars, t++) = c;
            }

            if(t!=0)
            {
                ref readonly var symbol = ref skip(symbols,k);
                seek(tokens, counter++) = new Token(k++, symbol, text.format(slice(chars, 0, t)));
                chars.Clear();
            }
            return slice(tokens,0,counter);
        }

        public static ReadOnlySpan<Token<K>> tokenize<K>(out ReadOnlySpan<byte> data)
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
            data = recover<byte>(src);
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