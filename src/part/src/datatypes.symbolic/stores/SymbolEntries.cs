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

    public readonly struct SymbolEntries<E>
    {
        readonly Index<SymbolEntry<E>> Data;

        readonly Dictionary<string,SymbolEntry<E>> Keys;

        [MethodImpl(Inline)]
        internal SymbolEntries(Index<SymbolEntry<E>> src, Dictionary<string,SymbolEntry<E>> keys)
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
        public ref readonly SymbolEntry<E> Entry(uint index)
            => ref Data[index];

        public ReadOnlySpan<SymbolEntry<E>> Entries
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