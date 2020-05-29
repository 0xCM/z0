//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;
    using System.Text;
    
    using A = AsciAlphabet;

    using static Seed;

    /// <summary>
    /// Encloses a finite and nontmpy sequence of symbols that comprise the Asci alphabet
    /// </summary>
    public readonly struct AsciAlphabet : IAlphabet<A>
    {   
        /// <summary>
        /// Retrieves the singleton instance of the alphabet
        /// </summary>
        public static AsciAlphabet Get()
            => TheOnly;

        static readonly AsciAlphabet TheOnly = new AsciAlphabet(
              AsciDigitSet.Symbols.Concat(AsciEscapeSet.Symbols.Concat(AsciLower.Symbols.Concat(AsciSymSet.Symbols.Concat(AsciUpper.Symbols))))); 
        
        AsciAlphabet(params Symbol<A>[] src)
            => Symbols = src.ToArray();
        
        public readonly Symbol<A>[] Symbols;

        IEnumerable<Symbol<A>> IAlphabet<A>.Symbols 
            => Symbols;

        public string Format()
        {
            var fmt = new StringBuilder();
            foreach(var s in Symbols)
                fmt.Append(s.Format());
            return fmt.ToString();
        }
    }
}