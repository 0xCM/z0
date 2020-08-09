//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DelimitedList<T> : ITextual
    {
        public readonly T[] Data;

        public readonly char Delimiter;

        [MethodImpl(Inline)]
        public static implicit operator DelimitedList<T>(T[] src)
            => new DelimitedList<T>(src);
        
        [MethodImpl(Inline)]
        public DelimitedList(T[] src, char delimiter = Chars.Comma)
        {
            Data = src;
            Delimiter = delimiter;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.bracket(text.join($"{Delimiter} ", Data));
    }
}