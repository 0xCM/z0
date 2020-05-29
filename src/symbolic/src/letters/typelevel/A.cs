//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class LetterTypes
    {
        public readonly struct A : ILetter<A>
        {
            [MethodImpl(Inline)]
            public static implicit operator AsciLetterCode(A src) 
                => src.Code;

            [MethodImpl(Inline)]
            public static implicit operator AsciLetter(A src) 
                => src.Symbol;

            [MethodImpl(Inline)]
            public static implicit operator char(A src) 
                => src.Character;
            
            public AsciLetter Symbol 
            {
                [MethodImpl(Inline)]
                get => AsciLetter.A;
            }

            public AsciLetterCode Code 
            {
                [MethodImpl(Inline)]
                get => AsciLetterCode.A;
            }

            public char Character
            {
                [MethodImpl(Inline)]
                get => (char)AsciLetter.A;
            }

            public override int GetHashCode()
                => (int)Code;

            [MethodImpl(Inline)]
            public bool Equals(A src)
                => true;

            public override bool Equals(object src)
                => src is A;

            [MethodImpl(Inline)]
            public string Format() 
                => Symbol.ToString();

            public override string ToString() 
                => Format();
        }
    }
}