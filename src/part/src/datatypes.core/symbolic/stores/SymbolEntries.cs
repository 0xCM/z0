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

    public readonly struct SymbolEntries<K>
        where K : unmanaged
    {
        readonly Index<SymbolEntry<K>> Data;

        readonly Dictionary<string,SymbolEntry<K>> Keys;

        [MethodImpl(Inline)]
        internal SymbolEntries(Index<SymbolEntry<K>> src, Dictionary<string,SymbolEntry<K>> keys)
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
            if(Keys.TryGetValue(symbol, out var entry))
            {
                index = entry.Index;
                return true;
            }
            index = uint.MaxValue;
            return false;
        }

        [MethodImpl(Inline)]
        public ref readonly SymbolEntry<K> Entry(uint index)
            => ref Data[index];

        public ReadOnlySpan<SymbolEntry<K>> Entries
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