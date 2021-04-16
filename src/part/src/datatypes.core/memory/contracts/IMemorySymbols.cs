//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMemorySymbols
    {
        MemorySymbol FromAddress(MemoryAddress address);

        SymExpr Expression(uint index);

        bool IsDefined(uint index);

        MemorySymbol Deposit(MemoryAddress address, ByteSize size, SymExpr expr);
    }
}