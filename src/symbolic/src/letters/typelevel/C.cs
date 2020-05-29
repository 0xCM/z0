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
        public readonly struct C : ILetter<C>
        {
            [MethodImpl(Inline)]
            public static implicit operator AsciLetterCode(C src) 
                => src.Code;

            [MethodImpl(Inline)]
            public static implicit operator AsciLetter(C src) 
                => src.Symbol;

            [MethodImpl(Inline)]
            public static implicit operator char(C src) 
                => src.Character;
            
            public AsciLetter Symbol 
            {
                [MethodImpl(Inline)]
                get => AsciLetter.C;
            }

            public AsciLetterCode Code 
            {
                [MethodImpl(Inline)]
                get => AsciLetterCode.C;
            }

            public char Character
            {
                [MethodImpl(Inline)]
                get => (char)AsciLetter.C;
            }

            public override int GetHashCode()
                => (int)Code;
                
            [MethodImpl(Inline)]
            public bool Equals(C src)
                => true;

            public override bool Equals(object src)
                => src is C;

            [MethodImpl(Inline)]
            public string Format() 
                => Symbol.ToString();

            public override string ToString() 
                => Format();
        }
    }
}