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

        public static MemorySymbols alloc(int count)
            => new MemorySymbols((uint)count);

        Index<MemoryAddress> Addresses;

        Index<SymExpr> Expressions;

        Index<MemorySymbol> Deposited;

        uint CurrentIndex;

        uint Capacity;

        MemorySymbols(uint count)
        {
            Capacity = count;
            Addresses = alloc<MemoryAddress>(count);
            Expressions = alloc<SymExpr>(count);
            Deposited = alloc<MemorySymbol>(count);
            CurrentIndex = 0;
        }

        [MethodImpl(Inline), Op]
        public bool IsDefined(uint index)
            => (index < Capacity - 1) && Deposited[index].IsNonEmpty;

        [MethodImpl(Inline), Op]
        public SymExpr Expression(uint index)
            => index < Capacity-1 ? Expressions[index] : SymExpr.Empty;

        [Op]
        public MemorySymbol Deposit(MemoryAddress address, ByteSize size, SymExpr expr)
        {
            if(CurrentIndex < Capacity - 1)
            {
                Addresses[CurrentIndex] = address;
                Expressions[CurrentIndex] = expr;
                var deposited = new MemorySymbol(this, size, CurrentIndex);
                Deposited[CurrentIndex] = deposited;
                CurrentIndex++;
                return deposited;

            }
            else
                return MemorySymbol.Empty;
        }

        [Op]
        public MemorySymbol FromAddress(MemoryAddress address)
        {
            if(address != 0)
            {
                var addresses = Addresses.View;
                for(var i=0; i<Capacity; i++)
                {
                    if(skip(addresses,i) == address)
                        return Deposited[i];
                }
            }
            return MemorySymbol.Empty;
        }
    }
}