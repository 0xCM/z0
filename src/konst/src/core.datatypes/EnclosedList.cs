//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using K = ListEnclosureKind;

    public enum ListEnclosureKind : byte
    {
        Embraced = 0,

        Bracketed = 1,

        Parenthetical = 2
    }

    public readonly struct EnclosedList<T> : ITextual
    {
        public readonly T[] Data;

        public readonly ListEnclosureKind Kind;

        public readonly char Delimiter;

        [MethodImpl(Inline)]
        public static implicit operator EnclosedList<T>(T[] src)
            => new EnclosedList<T>(src);

        [MethodImpl(Inline)]
        public EnclosedList(T[] src, ListEnclosureKind kind = ListEnclosureKind.Embraced,  char delimiter =  Chars.Comma)
        {
            Data = src;
            Kind = kind;
            Delimiter = delimiter;
        }

        char Left => Kind == K.Embraced ? Chars.LBrace : Kind == K.Bracketed ? Chars.LBracket : Chars.LParen;


        char Right => Kind == K.Embraced ? Chars.RBrace : Kind == K.Bracketed ? Chars.RBracket : Chars.RParen;


        [MethodImpl(Inline)]
        public string Format()
            => string.Concat(Left, text.delimit(Data, Delimiter), Right);


        public override string ToString()
            => Format();
    }
}