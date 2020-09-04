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
}