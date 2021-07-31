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

    partial struct Symbols
    {
        [Op]
        public static ReadOnlySpan<SymToken> tokens(ReadOnlySpan<Type> src)
        {
            var dst = list<SymToken>();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var type = ref skip(src,i);
                var symbols = Symbols.untyped(type).View;
                for(var j=0; j<symbols.Length; j++)
                {
                    ref readonly var symbol = ref skip(symbols,j);
                    var record = new SymToken();
                    record.TokenType = type.Name;
                    record.Key = symbol.Key;
                    record.Name = symbol.Name;
                    record.Expr = symbol.Expr;
                    record.Description = symbol.Description;
                    dst.Add(record);
                }
            }
            return dst.ViewDeposited();
        }

        [Op]
        public static ReadOnlySpan<SymToken> tokens(Type src)
        {
            var symbols = Symbols.untyped(src).View;
            var count = symbols.Length;
            var buffer = alloc<SymToken>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                ref var record = ref seek(dst,i);
                record.TokenType = src.Name;
                record.Key = symbol.Key;
                record.Name =  symbol.Name;
                record.Expr = symbol.Expr;
                record.Description = symbol.Description;
            }
            return buffer;
        }

        public static ReadOnlySpan<SymToken> tokens<E>()
            where E : unmanaged, Enum
                => tokens(typeof(E));
    }
}