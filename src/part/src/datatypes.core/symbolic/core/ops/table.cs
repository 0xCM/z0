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

    partial struct Symbols
    {
        public static SymTable<E> table<E>()
            where E : unmanaged, Enum
        {
            var literals = SymbolicLiterals.load<E>();
            var view = literals.View;
            var count = view.Length;
            var buffer = alloc<Token<E>>(count);
            ref var dst = ref first(buffer);
            var symbols = new Dictionary<string,Token<E>>(count);
            var identifiers = new Dictionary<string,Token<E>>(count);
            for(var i=0u; i<count; i++)
            {
                seek(dst, i) = new Token<E>(skip(view, i));
                symbols.Add(seek(dst,i).SymbolText, skip(dst, i));
                identifiers.Add(skip(dst,i).Identifier, skip(dst,i));
            }
            return new SymTable<E>(buffer, identifiers, symbols);
        }

        [Op]
        public static SymTable table(Type src)
        {
            var literals = SymbolicLiterals.symbolic(src);
            var view = literals.View;
            var count = view.Length;
            var buffer = alloc<Token>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst, i) = new Token(src, skip(view, i));
            return table(buffer);
        }

        [Op]
        public static SymTable table(Index<Token> src)
        {
            var view = src.View;
            var count = view.Length;
            var index = root.dict<string,Token>(count);
            var identifiers = root.dict<string,Token>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var token = ref skip(view, i);
                index.Add(token.SymbolText, token);
                identifiers.Add(skip(view,i).Identifier, token);
            }
            return new SymTable(src, identifiers, index);
        }
    }
}