//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = ListEnclosureKind;

    public enum ListEnclosureKind : byte
    {
        Embraced = 0,

        Bracketed = 1,

        Parenthetical = 2
    }

    public readonly struct EnclosedList<T> : ITextual
    {
        public T[] Data {get;}

        public ListEnclosureKind Kind {get;}

        public char Delimiter {get;}

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

        [MethodImpl(Inline)]
        public static implicit operator EnclosedList<T>(T[] src)
            => new EnclosedList<T>(src);
    }
}