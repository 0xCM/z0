//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class Grammar<G,K>
        where G : Grammar<G,K>, new()
        where K : unmanaged
    {
        /// <summary>
        /// Specifies the symbols covered by the grammar
        /// </summary>
        public Alphabet<K> Alphabet {get; protected set;}

        /// <summary>
        /// Specifies the initial/start symbol
        /// </summary>
        public Symbol<K> S0 {get; protected set;}

        protected Grammar()
        {
            Alphabet = default;
        }
    }
}