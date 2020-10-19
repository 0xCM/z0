//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISymbolic : ISymExpr
    {

    }

    public interface ISymbolic<H,S> :  ISymbolic, ISymExpr<H,S>
        where H : struct, ISymbolic<H,S>
        where S : unmanaged
    {

    }

    public interface ISymbolic<H,S,T,N> : ISymbol<S,T,N>
        where H : unmanaged, ISymbolic<H,S,T,N>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {

    }
}