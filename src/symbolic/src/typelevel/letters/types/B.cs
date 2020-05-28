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
        public readonly struct B : ILetter<B>
        {
            [MethodImpl(Inline)]
            public static implicit operator AsciLetterCode(B src) 
                => src.Code;

            [MethodImpl(Inline)]
            public static implicit operator AsciLetter(B src) 
                => src.Symbol;

            [MethodImpl(Inline)]
            public static implicit operator char(B src) 
                => src.Character;
            
            public AsciLetter Symbol 
            {
                [MethodImpl(Inline)]
                get => AsciLetter.B;
            }

            public AsciLetterCode Code 
            {
                [MethodImpl(Inline)]
                get => AsciLetterCode.B;
            }

            public char Character
            {
                [MethodImpl(Inline)]
                get => (char)AsciLetter.B;
            }

            public override int GetHashCode()
                => (int)Code;
                
            [MethodImpl(Inline)]
            public bool Equals(B src)
                => true;

            public override bool Equals(object src)
                => src is B;

            [MethodImpl(Inline)]
            public string Format() 
                => Symbol.ToString();

            public override string ToString() 
                => Format();
        }
    }
}