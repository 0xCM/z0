//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public class MemorySymbols
    {
        public static MemorySymbols alloc(uint capacity)
            => new MemorySymbols(capacity);

        public static MemorySymbols alloc(int capacity)
            => new MemorySymbols((uint)capacity);

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
            => memory.lookup(slice(_Symbols.Edit,0, EntryCount).ToArray());
        // {
        //     var count = EntryCount;
        //     var src = slice(_Symbols.Edit, 0, count);
        //     ref var dst = ref first(src);
        //     for(var i=0u; i<count; i++)
        //         seek(dst,i).HashCode = memory.hash(count, skip(src,i).Address);
        //     return new MemoryLookup(_Symbols, count);
        // }

    }
    partial struct Msg
    {
        public static MsgPattern<MemoryAddress,uint,MemoryAddress> SymbolHashMismatch
            => "The hashed address {0} at index {1} does not match the symbol address {2} at the corresponding index";
    }
}