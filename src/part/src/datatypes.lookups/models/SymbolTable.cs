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
        public static SymbolTable<T> create<T>(Index<T> src)
            => new SymbolTable<T>(src, t => t.ToString());

        public static SymbolTable<T> create<T>(Index<T> src, Func<T,Name> symbolizer)
            => new SymbolTable<T>(src, symbolizer);
    }

    public class SymbolTable<T>
    {
        readonly Index<T> Data;

        readonly Dictionary<string,Paired<uint,T>> Keys;

        internal SymbolTable(Index<T> src, Func<T,Name> symbolizer)
        {
            Data = src;
            Keys = new Dictionary<string, Paired<uint,T>>(src.Length);
            var entries = src.View;
            var count = entries.Length;
            for(var i=0u; i<count; i++)
            {
                var item = memory.skip(entries, i);
                Keys.Add(symbolizer(item), (i,item));
            }
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