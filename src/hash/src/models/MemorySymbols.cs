//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public class MemorySymbols
    {
        /// <summary>
        /// Hashes an address
        /// </summary>
        /// <param name="capacity">The number slots in the bucket</param>
        /// <param name="src">The address to hash</param>
        [MethodImpl(Inline), Op]
        public static uint hash(MemoryAddress src)
            => (uint)src;

        [Op]
        public static uint hash(ReadOnlySpan<MemoryAddress> src, Span<AddressHash> dst)
        {
            var count = (uint)src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var address = ref skip(src,i);
                ref var target = ref seek(dst,i);
                if(address == 0)
                    continue;

                target.Index = i;
                target.Address = address;
                target.HashCode = hash(address);
            }
            return count;
        }


        public static MemorySymbols alloc(uint capacity)
            => new MemorySymbols(capacity);

        public static MemorySymbols alloc(int capacity)
            => new MemorySymbols((uint)capacity);

        [MethodImpl(Inline), Op]
        public static uint bucket(MemoryAddress src, uint capacity)
            => hash(src) % (capacity - 1);

        [MethodImpl(Inline), Op]
        public static uint bucket(Hash32 hash, uint capacity)
            => hash % (capacity - 1);

        public static MemoryLookup lookup(Index<MemorySymbol> symbols, uint count)
        {
            var capacity = (uint)symbols.Length;
            var keys = alloc<uint>(capacity);
            ref var k = ref first(keys);
            ref var s = ref symbols.First;
            for(var i=0; i<count; i++)
            {
                ref var symbol = ref seek(s,i);
                symbol.HashCode = hash(symbol.Address);
                seek(k,  bucket(symbol.HashCode, capacity)) = symbol.Index;

            }
            return new MemoryLookup(symbols, keys, capacity);
        }

        Index<MemoryAddress> _Addresses;

        Index<MemorySymbol> _Symbols;

        uint CurrentIndex;

        uint Capacity;

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => CurrentIndex;
        }

        public ReadOnlySpan<MemoryAddress> Addresses
        {
            [MethodImpl(Inline)]
            get => slice(_Addresses.View,0,EntryCount);
        }

        MemorySymbols(uint count)
        {
            Capacity = count;
            _Addresses = alloc<MemoryAddress>(count);
            _Symbols = alloc<MemorySymbol>(count);
            CurrentIndex = 0;
        }

        [MethodImpl(Inline), Op]
        public bool IsDefined(uint index)
            => (index < Capacity - 1) && _Symbols[index].IsNonEmpty;

        [Op]
        public MemorySymbol Deposit(MemoryAddress address, ByteSize size, SymExpr expr)
        {
            if(CurrentIndex < Capacity - 1)
            {
                _Addresses[CurrentIndex] = address;
                var deposited = new MemorySymbol(CurrentIndex, 0, address, size, expr);
                _Symbols[CurrentIndex] = deposited;
                CurrentIndex++;
                return deposited;
            }
            else
                return MemorySymbol.Empty;
        }

        public MemoryLookup ToLookup()
            => lookup(_Symbols, EntryCount);
    }

    partial struct Msg
    {
        public static MsgPattern<MemoryAddress,uint,MemoryAddress> SymbolHashMismatch
            => "The hashed address {0} at index {1} does not match the symbol address {2} at the corresponding index";
    }
}