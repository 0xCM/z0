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
        public static SymbolEntries<E> entries<E>()
            where E : unmanaged, Enum
        {
            var literals = ClrPrimitives.enums<E>();
            var view = literals.View;
            var count = view.Length;
            var entries = memory.alloc<SymbolEntry<E>>(count);
            ref var entry = ref memory.first(entries);
            var index = new Dictionary<string,SymbolEntry<E>>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(view, i);
                seek(entry, i) = new SymbolEntry<E>(i, literal);
                index.Add(literal.Name, skip(entry, i));
            }
            return new SymbolEntries<E>(entries, index);
        }

        public static SymbolTable<T> create<T>(Index<T> src, Action<string,Paired<uint,T>> error = null)
            => create<T>(src, t => t.ToString(), error);

        public static SymbolTable<T> create<T>(Index<T> src, Func<T,Name> symbolizer, Action<string,Paired<uint,T>> error = null)
        {
            var keys = new Dictionary<string, Paired<uint,T>>(src.Length);
            var entries = src.View;
            var count = entries.Length;
            for(var i=0u; i<count; i++)
            {
                var item = memory.skip(entries, i);
                var value = root.paired(i,item);
                var symbol = symbolizer(item);
                if(!keys.TryAdd(symbol, value))
                {
                    if(error != null)
                        error(symbol,value);
                    else
                        root.@throw(new Exception($"The symbol {symbol} for {value} is duplicated"));
                }
            }
            return new SymbolTable<T>(src,keys);
        }
    }
}