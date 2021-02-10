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
        public static SymbolTable<T> create<T>(Index<T> src, Action<string,Paired<uint,T>> duphandler = null)
            => create<T>(src, t => t.ToString(), duphandler);

        public static SymbolTable<T> create<T>(Index<T> src, Func<T,Name> symbolizer, Action<string,Paired<uint,T>> duphandler = null)
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
                    if(duphandler != null)
                        duphandler(symbol,value);
                    else
                        root.@throw(new Exception($"The symbol {symbol} for {value} is duplicated"));
                }
            }
            return new SymbolTable<T>(src,keys);
        }
    }

    public class SymbolTable<T>
    {
        readonly Index<T> Data;

        readonly Dictionary<string,Paired<uint,T>> Keys;

        internal SymbolTable(Index<T> src, Dictionary<string,Paired<uint,T>> keys)
        {
            Data = src;
            Keys = keys;
        }

        [MethodImpl(Inline)]
        public bool Contains(Name symbol)
            => Keys.ContainsKey(symbol);

        [MethodImpl(Inline)]
        public bool Index(Name symbol, out uint index)
        {
            if(Keys.TryGetValue(symbol, out var pair))
            {
                index = pair.Left;
                return true;
            }
            index = uint.MaxValue;
            return false;
        }

        [MethodImpl(Inline)]
        public ref readonly T Entry(uint index)
            => ref Data[index];

        public ReadOnlySpan<T> Entries
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}