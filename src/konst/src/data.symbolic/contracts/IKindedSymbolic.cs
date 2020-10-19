//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a classified symbol
    /// </summary>
    /// <typeparam name="K">The classifier type</typeparam>
    /// <typeparam name="S">The symbol type</typeparam>
    public interface IKindedSymbolic<H,K,S,T,N> : IKindedSymbol<K,S,T>, ISymbol<S,T,N>
        where H : unmanaged, IKindedSymbolic<H,K,S,T,N>
        where K : unmanaged
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {

    }
}