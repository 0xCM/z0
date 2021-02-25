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
        // public static SymbolEntries<E> entries<E>()
        //     where E : unmanaged, Enum
        // {
        //     var literals = ClrPrimitives.enums<E>();
        //     var view = literals.View;
        //     var count = view.Length;
        //     var entries = memory.alloc<SymbolEntry<E>>(count);
        //     ref var entry = ref memory.first(entries);
        //     var index = new Dictionary<string,SymbolEntry<E>>(count);
        //     for(var i=0u; i<count; i++)
        //     {
        //         ref readonly var literal = ref skip(view, i);
        //         seek(entry, i) = new SymbolEntry<E>(i, literal);
        //         index.Add(literal.Name, skip(entry, i));
        //     }
        //     return new SymbolEntries<E>(entries, index);
        // }

        public static SymbolTable<E> create<E>(Func<E,Name> symbolizer = null)
            where E : unmanaged, Enum
        {
            var literals = ClrPrimitives.enums<E>();
            var view = literals.View;
            var count = view.Length;
            var entries = memory.alloc<Token<E>>(count);
            ref var entry = ref memory.first(entries);
            var index = new Dictionary<string,Token<E>>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(view, i);
                seek(entry, i) = new Token<E>(i, literal.Name, literal.DirectValue, symbolizer != null ? symbolizer(literal.DirectValue) : literal.Name);
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

        // public static SymbolTable<T> create<T>(Index<T> src, Func<T,Name> symbolizer, Action<string,Paired<uint,T>> error = null)
        // {
        //     var keys = new Dictionary<string, Paired<uint,T>>(src.Length);
        //     var entries = src.View;
        //     var count = entries.Length;
        //     for(var i=0u; i<count; i++)
        //     {
        //         var item = memory.skip(entries, i);
        //         var value = root.paired(i,item);
        //         var symbol = symbolizer(item);
        //         if(!keys.TryAdd(symbol, value))
        //         {
        //             if(error != null)
        //                 error(symbol,value);
        //             else
        //                 root.@throw(new Exception($"The symbol {symbol} for {value} is duplicated"));
        //         }
        //     }
        //     return new SymbolTable<T>(src, keys);
        // }
    }
}