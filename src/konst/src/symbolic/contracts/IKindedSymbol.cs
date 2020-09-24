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
    public interface IKindedSymbol<K,S> : ISymbol<S>
        where K : unmanaged
        where S : unmanaged
    {
        /// <summary>
        /// The symbol kind
        /// </summary>
        K Kind {get;}
    }

    /// <summary>
    /// Characterizes a classified symbol
    /// </summary>
    /// <typeparam name="K">The classifier type</typeparam>
    /// <typeparam name="S">The symbol type</typeparam>
    public interface IKindedSymbol<K,S,T> : IKindedSymbol<K,S>, ISymbol<S,T>
        where K : unmanaged
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a classified symbol
    /// </summary>
    /// <typeparam name="K">The classifier type</typeparam>
    /// <typeparam name="S">The symbol type</typeparam>
    public interface IKindedSymbol<K,S,T,N> : IKindedSymbol<K,S,T>, ISymbol<S,T,N>
        where K : unmanaged
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {

    }

}