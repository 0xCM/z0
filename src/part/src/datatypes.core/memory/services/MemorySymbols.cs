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
    public class MemorySymbols : IMemorySymbols
    {
        public static MemorySymbols alloc(uint count)
            => new MemorySymbols(count);

        Index<MemoryAddress> Addresses;

        Index<string> Names;

        uint CurrentIndex;

        uint Capacity;

        MemorySymbols(uint count)
        {
            Capacity = count;
            Addresses = alloc<MemoryAddress>(count);
            Names = alloc<string>(count);
            CurrentIndex = 0;
        }

        [MethodImpl(Inline), Op]
        public string SymbolName(uint index)
            => index < Capacity-1 ? Names[index] ?? EmptyString : EmptyString;

        [Op]
        public MemorySymbol Deposit(MemoryAddress address, string name)
        {
            if(CurrentIndex < Capacity - 1)
            {
                Addresses[CurrentIndex] = address;
                Names[CurrentIndex] = name;
                var symbol = new MemorySymbol(this, CurrentIndex);
                CurrentIndex++;
                return symbol;

            }
            else
                return MemorySymbol.Empty;
        }

        [Op]
        public string SymbolName(MemoryAddress address)
        {
            if(address != 0)
            {
                var addresses = Addresses.View;
                for(var i=0; i<Capacity; i++)
                {
                    if(skip(addresses,i) == address)
                        return Names[i];
                }
            }
            return EmptyString;
        }
    }
}