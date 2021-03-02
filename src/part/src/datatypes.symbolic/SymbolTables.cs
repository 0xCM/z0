//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public readonly struct SymbolTables
    {
        public static SymbolTable<E> create<E>(Func<E,Name> symbolizer = null)
            where E : unmanaged, Enum
        {
            var literals = ClrPrimitives.enums<E>();
            var view = literals.View;
            var count = view.Length;
            var entries = alloc<Token<E>>(count);
            ref var entry = ref first(entries);
            var index = new Dictionary<string,Token<E>>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(view, i);
                var symbol = symbolizer != null ? symbolizer(literal.DirectValue).Format() : literal.Symbol.Format();
                seek(entry, i) = new Token<E>(i, literal.Name, literal.DirectValue, symbol);
                index.Add(literal.UniqueName, skip(entry, i));
            }
            return new SymbolTable<E>(entries, index);
        }

        public static SymbolTable<E> create<E>(Index<Token<E>> src)
            where E : unmanaged, Enum
        {
            var view = src.View;
            var count = view.Length;
            var index = new Dictionary<string,Token<E>>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var token = ref skip(view, i);
                index.Add(token.Name, token);
            }
            return new SymbolTable<E>(src, index);
        }
    }
}