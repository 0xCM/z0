//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    using static Root;
    using A = AsciAlphabet;

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
              AsciDigits.Symbols.Concat(AsciEscape.Symbols.Concat(AsciLower.Symbols.Concat(AsciSym.Symbols.Concat(AsciUpper.Symbols))))); 
        
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