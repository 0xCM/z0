//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct EnclosedList<T> : ITextual
    {
        public Index<T> Data {get;}

        public SeqEnclosureKind Kind {get;}

        public char Delimiter {get;}

        [MethodImpl(Inline)]
        public EnclosedList(T[] src, SeqEnclosureKind kind = SeqEnclosureKind.Embraced,  char delimiter =  Chars.Comma)
        {
            Data = src;
            Kind = kind;
            Delimiter = delimiter;
        }

        public string Format()
            => string.Concat(seq.left(Kind), text.delimit(Data.View, Delimiter), seq.right(Kind));

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator EnclosedList<T>(T[] src)
            => new EnclosedList<T>(src);
    }
}