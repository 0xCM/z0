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

    public readonly struct SymbolTables
    {
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