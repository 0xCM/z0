//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class Grammar<G,K,T>
        where G : Grammar<G,K,T>, new()
        where K : unmanaged
        where T : IExpr
    {
        /// <summary>
        /// Specifies the symbols covered by the grammar
        /// </summary>
        public Alphabet<K> Alphabet {get; protected set;}

        /// <summary>
        /// Specifies the initial/start symbol
        /// </summary>
        public Atom<K> S0 {get; protected set;}

        public Index<Production<T>> Productions {get;}

        protected Grammar()
        {
            Alphabet = default;
        }
    }
}