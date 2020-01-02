//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zfunc;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a collection of symbols from an alphabet
    /// </summary>
    /// <typeparam name="A"></typeparam>
    public abstract class SymbolSet<S,A,K>
        where A : struct, IAlphabet<A>
        where S : SymbolSet<S,A,K>, new()
    {
            
        /// <summary>
        /// Symbol set allocation that must be populated by the concrete subtype
        /// </summary>
        protected static Symbol<A>[] _Symbols;   

        /// <summary>
        /// Symbol accessor
        /// </summary>
        public static Symbol<A>[] Symbols 
            => _Symbols;
    }

    /// <summary>
    /// Represents a collection of symbols from an alphabet whose symbols can be reduced to a single charactger
    /// </summary>
    /// <typeparam name="A"></typeparam>
    public abstract class SymbolSet<S,A> : SymbolSet<S,A,char>
        where A : struct, IAlphabet<A>
        where S : SymbolSet<S,A>, new()
    {        
        public static Symbol<A> Find(char key)
            => SymbolIndex[key];
        
        protected static readonly IDictionary<char, Symbol<A>> SymbolIndex 
            = _Symbols.Select(s => (s[0],s)).ToDictionary(x => x.Item1, x => x.s);

        public Symbol<A> this[char key]
            => SymbolIndex[key];
    }
}