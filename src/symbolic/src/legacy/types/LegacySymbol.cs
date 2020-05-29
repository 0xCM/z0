//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Symbolic;

    using static Seed;

    /// <summary>
    /// Represents an atomic value
    /// </summary>
    public readonly struct LegacySymbol
    {
        public static LegacySymbol Empty => new LegacySymbol(string.Empty);

        [MethodImpl(Inline)]
        public static LegacySymbol Define(string text)
            => new LegacySymbol(text);
        
        [MethodImpl(Inline)]
        public static bool operator ==(LegacySymbol lhs, LegacySymbol rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator !=(LegacySymbol lhs, LegacySymbol rhs)
            => lhs != rhs;
            
        [MethodImpl(Inline)]
        public static implicit operator string(LegacySymbol s)                
            => s.data;

        [MethodImpl(Inline)]
        public LegacySymbol(string data)
            => this.data = data;

        readonly string data;

        [MethodImpl(Inline)]
        public bool Equals(LegacySymbol rhs)
            => data.Equals(rhs.data);

        public override string ToString() 
            => data.ToString();

        public override bool Equals(Object rhs)
            => rhs is LegacySymbol s ? Equals(s) : false;

        public override int GetHashCode() 
            => data.GetHashCode();
    }   

    /// <summary>
    /// Represents a symbol belonging to an alphabet A
    /// </summary>
    public readonly struct LegacySymbol<A> : ILegacySymbol<A>
        where A : struct, ILegacyAlphabet<A>
    {        
        readonly char c0;
        
        readonly char c1;

        /// <summary>
        /// Uses the unicode null symbol to represent an empty character
        /// </summary>
        const char EmptyChar = '\0';

        public static LegacySymbol<A> Empty => new LegacySymbol<A>(string.Empty);
        
        [MethodImpl(Inline)]
        public static LegacySymbol<A> Define(string text)
            => new LegacySymbol<A>(text);
        
        [MethodImpl(Inline)]
        public static LegacySymbol<A> Define(char c0, char? c1 = null)
            => new LegacySymbol<A>(c0, c1);

        [MethodImpl(Inline)]
        public static implicit operator LegacySymbol<A>(char c0)
            => Define(c0);

        [MethodImpl(Inline)]
        public static implicit operator LegacySymbol<A>(AsciLetterLo c0)
            => Define((char)c0);

        [MethodImpl(Inline)]
        public static implicit operator LegacySymbol<A>(AsciLetterUp c0)
            => Define((char)c0);

        /// <summary>
        /// Concatenates two symbols to form a word
        /// </summary>
        /// <param name="lhs">The left symbol, which will form the head of the new word</param>
        /// <param name="rhs">The right symbol, which will form the tail of the new word</param>
        [MethodImpl(Inline)]
        public static LegacyWord<A> operator +(LegacySymbol<A> lhs, LegacySymbol<A> rhs)
            => new LegacySymbol<A>[]{lhs,rhs};

        [MethodImpl(Inline)]
        public static bool operator ==(LegacySymbol<A> lhs, LegacySymbol<A> rhs)
            => lhs.c0 == rhs.c0  && lhs.c1 == rhs.c1;

        [MethodImpl(Inline)]
        public static bool operator !=(LegacySymbol<A> lhs, LegacySymbol<A> rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool operator ==(LegacySymbol<A> lhs, char rhs)
            => lhs.c0 == rhs && lhs.c1 == EmptyChar;

        [MethodImpl(Inline)]
        public static bool operator !=(LegacySymbol<A> lhs, char rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool operator ==(char lhs, LegacySymbol<A> rhs)
            => lhs == rhs.c0 && rhs.c1 == EmptyChar;

        [MethodImpl(Inline)]
        public static bool operator !=(char lhs, LegacySymbol<A> rhs)
            =>lhs != rhs;

        [MethodImpl(Inline)]
        public LegacySymbol(char c0, char? c1 = null)
        {
            this.c0 = c0;
            this.c1 = c1 ?? EmptyChar;
        }

        [MethodImpl(Inline)]
        public LegacySymbol(string data)
        {
            if(data.Length == 1)
            {
                c0 = data[0];
                c1 = EmptyChar;
            }
            else if(data.Length == 2)
            {
                c0 = data[0];
                c1 = data[1];
            }
            else
                throw new ArgumentException($"Symbol data has length of either 1 or 2");        
        }

        public char this[int index]            
        {
            get
            {
                if(index == 0)
                    return c0;
                else if(index == 1)
                    return c1;
                else
                    throw new ArgumentException($"Symbol data is indexed by 0 and 1");
            }
        }

        [MethodImpl(Inline)]
        public bool Equals(LegacySymbol<A> rhs)
            => this == rhs;
        
        public ReadOnlySpan<char> Content
            => c1 != EmptyChar ? new char[]{c0,c1} : new char[c0];

        public string Format()
            => c1 == EmptyChar ? c0.ToString() : $"{c0}{c1}";   
        
        public override string ToString() 
            => Format();

        public override bool Equals(object rhs)
            => rhs is LegacySymbol<A> s ? Equals(s) : false;

        public override int GetHashCode() 
            =>  HashCode.Combine(c0, c1);
   }
}