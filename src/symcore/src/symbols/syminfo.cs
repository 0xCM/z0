//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    partial struct Symbols
    {
        [Op]
        public static ReadOnlySpan<SymInfo> syminfo(ReadOnlySpan<Type> src)
        {
            var dst = list<SymInfo>();
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var type = ref skip(src,i);
                var symbols = untyped(type).View;
                for(var j=0; j<symbols.Length; j++)
                {
                    ref readonly var symbol = ref skip(symbols,j);
                    var record = new SymInfo();
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
        public static ReadOnlySpan<SymInfo> syminfo(Type src)
        {
            var symbols = Symbols.untyped(src).View;
            var count = symbols.Length;
            var buffer = alloc<SymInfo>(count);
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

        public static ReadOnlySpan<SymInfo> syminfo<E>()
            where E : unmanaged, Enum
                => syminfo(typeof(E));

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
    }
}