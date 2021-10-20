//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public sealed class SymbolSet<K>
        where K : unmanaged
    {
        readonly Index<Symbol<K>> SymbolData;

        readonly Dictionary<uint,uint> KeyToOrder;
        
        readonly Dictionary<K,uint> ValueToKey;

        public SymbolSet(Symbol<K>[] src)
        {
            SymbolData = src;
            ValueToKey = new();
            KeyToOrder = new();
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var s = ref SymbolData[i];
                KeyToOrder[s.Key] = i;
                ValueToKey[s.Value] = s.Key;
            }
        }

        public uint SymbolCount
        {
            [MethodImpl(Inline)]
            get => SymbolData.Count;
        }

        public ReadOnlySpan<Symbol<K>> Members
        {
            [MethodImpl(Inline)]
            get => SymbolData.View;
        }
    
        /// <summary>
        /// Searches for a key-predicated symbol, returning true upon success and false otherwise
        /// </summary>
        /// <param name="key">The symbol key</param>
        /// <param name="dst">The matching symbol, if found</param>
        [MethodImpl(Inline)]
        public bool Symbol(uint key, out Symbol<K> dst)
        {
            if(KeyToOrder.TryGetValue(key, out var order))
            {
                dst = SymbolData[order];
                return true;
            }
            else
            {
                dst = Symbol<K>.Empty;
                return false;
            }
        }

        [MethodImpl(Inline)]
        public bool Key(K src, out uint key)
        {
            if(ValueToKey.TryGetValue(src, out key))
                return true;
            else
            {
                key = default;
                return false;
            }
        }

        public Symbol<K> this[uint key]
        {
            [MethodImpl(Inline)]
            get
            {
                if(Symbol(key, out var dst))
                    return dst;
                else
                    return Symbol<K>.Empty;
            }
        }

        public uint this[K value]
        {
            [MethodImpl(Inline)]
            get => Key(value, out var dst) ? dst : default;
        }

        internal Symbol<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => SymbolData;
        }
    }
}