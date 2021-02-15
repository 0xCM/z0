//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISymbolSet<S> : ISymbolInfo
        where S : unmanaged
    {
        S[] Symbols {get;}

        ref readonly S this[ushort index]
             => ref memory.seek(Symbols,index);
    }

    public interface ISymbolSet<H,S> : ISymbolSet<S>
        where S : unmanaged
        where H : struct, ISymbolSet<H,S>
    {

    }
}