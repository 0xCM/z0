//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class LetterTypes
    {
        public readonly struct D : ILetter<D>
        {
            [MethodImpl(Inline)]
            public static implicit operator AsciLetterCode(D src) 
                => src.Code;

            [MethodImpl(Inline)]
            public static implicit operator AsciLetter(D src) 
                => src.Symbol;

            [MethodImpl(Inline)]
            public static implicit operator char(D src) 
                => src.Character;
            
            public AsciLetter Symbol 
            {
                [MethodImpl(Inline)]
                get => AsciLetter.D;
            }

            public AsciLetterCode Code 
            {
                [MethodImpl(Inline)]
                get => AsciLetterCode.D;
            }

            public char Character
            {
                [MethodImpl(Inline)]
                get => (char)AsciLetter.D;
            }

            public override int GetHashCode()
                => (int)Code;
                
            [MethodImpl(Inline)]
            public bool Equals(D src)
                => true;

            public override bool Equals(object src)
                => src is D;

            [MethodImpl(Inline)]
            public string Format() 
                => Symbol.ToString();

            public override string ToString() 
                => Format();
        }
    }
}