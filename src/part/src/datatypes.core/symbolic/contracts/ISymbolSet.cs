//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISymbolSet : ISymbolInfo
    {
        ushort SymCount {get;}
    }

    public interface ISymbolSet<S> : ISymbolSet
        where S : unmanaged
    {
        Index<S> Symbols {get;}

        Identifier SymId(ushort index);

        ref readonly S this[ushort index]
             => ref Symbols[index];
    }

    public interface ISymbolSet<H,S> : ISymbolSet<S>
        where S : unmanaged
        where H : struct, ISymbolSet<H,S>
    {

    }
}