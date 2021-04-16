//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMemorySymbols
    {
        SymExpr Expression(uint index);

        bool IsDefined(uint index);

        MemorySymbol Deposit(MemoryAddress address, ByteSize size, SymExpr expr);

        MemoryLookup Seal();
    }
}