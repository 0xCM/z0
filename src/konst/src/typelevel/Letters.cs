//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public class LetterTypes
    {
        public readonly struct A : IAsciLetter<A>
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

        public readonly struct B : IAsciLetter<B>
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

        public readonly struct C : IAsciLetter<C>
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

        public readonly struct D : IAsciLetter<D>
        {

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

            [MethodImpl(Inline)]
            public static implicit operator AsciLetterCode(D src)
                => src.Code;

            [MethodImpl(Inline)]
            public static implicit operator AsciLetter(D src)
                => src.Symbol;

            [MethodImpl(Inline)]
            public static implicit operator char(D src)
                => src.Character;
        }
    }
}