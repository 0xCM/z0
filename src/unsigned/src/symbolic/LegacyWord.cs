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
    
    using static Konst;

    /// <summary>
    /// Encodes a finite, ordered sequence of symbols over some alphabet A
    /// In the literature, a 'word' in this context is often referred to as a
    /// 'string' - the usage of which is avoided here, for obvious reasons.
    /// </summary>
    public readonly struct LegacyWord<A> : ILegacyWord<LegacyWord<A>,A>
        where A : struct, ILegacyAlphabet<A>
    {            
        /// <summary>
        /// Represents the empty word, with an invariant length of 0
        /// </summary>
        /// <typeparam name="A">The alphabet type</typeparam>
        public static LegacyWord<A> Empty => new LegacyWord<A>(LegacySymbol<A>.Empty);

        /// <summary>
        /// The symbols that comprise the word
        /// </summary>
        public readonly LegacySymbol<A>[] Symbols;

        /// <summary>
        /// Determines whether two words are equivalent
        /// </summary>
        /// <param name="lhs">The first word</param>
        /// <param name="rhs">The second word</param>
        public static bool operator == (LegacyWord<A> lhs, LegacyWord<A> rhs)
            => lhs.Symbols == rhs.Symbols;

        /// <summary>
        /// Determines whether two words are unequal
        /// </summary>
        /// <param name="lhs">The first word</param>
        /// <param name="rhs">The second word</param>
        public static bool operator != (LegacyWord<A> lhs, LegacyWord<A> rhs)
            => lhs != rhs;

        /// <summary>
        /// Converts the word to a string via a canonical format
        /// </summary>
        /// <param name="src">The source word</param>
        public static implicit operator string(LegacyWord<A> src)
            => src.Format();

        /// <summary>
        /// Encloses an array of symbols by a word
        /// </summary>
        /// <param name="src">The source symbols</param>
        /// <typeparam name="A">The alphabet</typeparam>
        public static implicit operator LegacyWord<A>(LegacySymbol<A>[] src)
            => new LegacyWord<A>(src);

        /// <summary>
        /// Converts a word to its equivalent symbolic representation
        /// </summary>
        /// <param name="src">The source word</param>
        public static implicit operator LegacySymbol<A>[](LegacyWord<A> src)
            => src.Symbols;
    
        /// <summary>
        /// Concatenates a word w1 with a word w2 to form a word w' = w1w2
        /// </summary>
        /// <param name="w1">The first word</param>
        /// <param name="w2">The second word</param>
        public static LegacyWord<A> operator +(LegacyWord<A> w1, LegacyWord<A> w2)
            => new LegacyWord<A>(w1,w2);

        /// <summary>
        /// The empty word containing no symbols
        /// </summary>
        public LegacyWord<A> Zero 
            => Empty;

        /// <summary>
        /// Specifies the number of symbols that comprise the word
        /// </summary>
        public int Length
            => Symbols.Length;

        [MethodImpl(Inline)]
        public LegacyWord(params LegacyWord<A>[] Words)
        {
            
            var len = Words.Sum(s => s.Length);
            this.Symbols = new LegacySymbol<A>[len];
            var symidx = 0;
            for(var i=0; i< Words.Length; i++)
            {
                var word = Words[i];
                for(var j = 0; j< word.Length; j++)
                    this.Symbols[symidx++] = word.Symbols[j];
            }
        }

        [MethodImpl(Inline)]
        public LegacyWord(params LegacySymbol<A>[] Symbols)
        {            
            if(Symbols.Length == 1 && Symbols[0] == LegacySymbol<A>.Empty)
                this.Symbols = new LegacySymbol<A>[]{};
            else
                this.Symbols = Symbols;
        }

        public LegacySymbol<A> this[int index]
        {
            [MethodImpl(Inline)]
            get => Symbols[index];
        }

        public bool IsEmpty
            => Symbols.Length == 0;

        public ReadOnlySpan<char> Content
            => string.Join(string.Empty, Symbols);

        /// <summary>
        /// Formats the word as a string
        /// </summary>
        public string Format()
            => string.Join(string.Empty, Symbols);

        [MethodImpl(Inline)]
        public bool Equals(LegacyWord<A> rhs)
        {
            if(Length != rhs.Length)
                return false;

            for(var i=0; i< rhs.Symbols.Length; i++)   
                if(!Symbols[i].Equals(rhs.Symbols[i]))
                    return false;
            return true;
        }

        public override int GetHashCode() 
            => Format().GetHashCode();

        public override string ToString() 
            => Format();

        public override bool Equals(Object rhs)
            => rhs is LegacyWord<A> ? Equals((LegacyWord<A>)rhs) : false;

        /// <summary>
        /// Concatenates this word w1 with another word w2 to form a new word w1w2
        /// </summary>
        /// <param name="w2">The word to concatenate with the current word</param>
        public LegacyWord<A> Concat(LegacyWord<A> w2)
            => new LegacyWord<A>(this,w2);
    }
}