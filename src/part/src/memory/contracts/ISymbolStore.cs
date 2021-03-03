//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface ISymbolStore
    {
        string SymbolName(uint id);

    }

    public interface ISymbolStore<S> : ISymbolStore
        where S : struct, IStoredSymbol<S>
    {

    }

    public interface IStoredSymbol
    {
        uint SymbolId {get;}

        string SymbolName {get;}
    }

    public interface IStoredSymbol<S> : IStoredSymbol
    {

    }

    public interface IMemorySymbols : ISymbolStore<MemorySymbol>
    {
        string SymbolName(MemoryAddress address);
    }
}