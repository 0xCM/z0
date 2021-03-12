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

    [ApiHost(ApiNames.SymbolStores, true)]
    public readonly partial struct SymbolStores
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates a symbol index from an unmanaged value sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="S">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<Symbol<S>> symbols<S>(params S[] src)
            where S : unmanaged
                => src.Map(symbol);

        [MethodImpl(Inline), Op]
        static SymbolSet<Symbol<AsciCharCode>,byte,W8> create_symbol_set_example(params AsciCharCode[] src)
            => set<Symbol<AsciCharCode>,byte,W8>(SymbolStores.symbols(src));

        public static SymbolTable<E> table<E>(Func<E,Name> symbolizer)
            where E : unmanaged, Enum
        {
            var literals = ClrEnums.symbolic<E>();
            var editor = literals.Edit;
            var count = editor.Length;
            var entries = alloc<Token<E>>(count);
            ref var dst = ref first(entries);
            var index = new Dictionary<string,Token<E>>(count);
            var identifiers = new Dictionary<string,Token<E>>(count);
            for(var i=0u; i<count; i++)
            {
                ref var literal = ref seek(editor, i);
                var symbol = symbolizer(literal.DirectValue);
                literal.Symbol = symbolizer(literal.DirectValue);
                seek(dst, i) = new Token<E>(literal);
                index.Add(skip(dst,i).Symbol, skip(dst, i));
                identifiers.Add(skip(dst,i).Name, skip(dst,i));
            }
            return new SymbolTable<E>(entries, identifiers, index);
        }

        public static SymbolTable<E> table<E>()
            where E : unmanaged, Enum
        {
            var literals = ClrEnums.symbolic<E>();
            var view = literals.View;
            var count = view.Length;
            var buffer = alloc<Token<E>>(count);
            ref var dst = ref first(buffer);
            var symbols = new Dictionary<string,Token<E>>(count);
            var identifiers = new Dictionary<string,Token<E>>(count);
            for(var i=0u; i<count; i++)
            {
                seek(dst, i) = new Token<E>(skip(view, i));
                symbols.Add(seek(dst,i).Symbol, skip(dst, i));
                identifiers.Add(skip(dst,i).Name, skip(dst,i));
            }
            return new SymbolTable<E>(buffer, identifiers, symbols);
        }

        public static SymbolTable<E> table<E>(Index<Token<E>> src)
            where E : unmanaged, Enum
        {
            var view = src.View;
            var count = view.Length;
            var index = new Dictionary<string,Token<E>>(count);
            var identifiers = new Dictionary<string,Token<E>>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var token = ref skip(view, i);
                index.Add(token.Symbol, token);
                identifiers.Add(skip(view,i).Name, token);
            }
            return new SymbolTable<E>(src, identifiers, index);
        }
    }
}