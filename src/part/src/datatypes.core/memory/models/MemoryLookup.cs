//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MemoryLookup
    {
        readonly Index<AddressHash> Hashed;

        readonly Index<MemorySymbol> _Symbols;

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => Hashed.Count;
        }

        [MethodImpl(Inline)]
        public MemoryLookup(Index<MemorySymbol> symbols, Index<AddressHash> hashed)
        {
            _Symbols = symbols;
            Hashed = hashed;
        }

        public ReadOnlySpan<AddressHash> Addresses
        {
            [MethodImpl(Inline)]
            get => Hashed.View;
        }

        public ReadOnlySpan<MemorySymbol> Symbols
        {
            [MethodImpl(Inline)]
            get => _Symbols.View;
        }

        [MethodImpl(Inline)]
        public bool IsBaseAddress(MemoryAddress address)
        {
            var index = memory.hash(EntryCount, address);
            return index < EntryCount && Hashed[index].Address == address;
        }

        [MethodImpl(Inline)]
        public bool RegionSize(MemoryAddress @base, out ByteSize size)
        {
            var index = memory.hash(EntryCount, @base);
            if(index < EntryCount && Hashed[index].Address == @base)
            {
                size = _Symbols[index].Size;
                return true;
            }
            else
            {
                size = default;
                return false;
            }
        }
    }
}