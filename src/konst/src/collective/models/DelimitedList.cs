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
    using static FormatFunctions;

    public readonly struct DelimitedList<T> : ITextual
    {
        public readonly T[] Data;

        public readonly char Delimiter;

        readonly DelimitArray<T,string> Render;

        [MethodImpl(Inline)]
        public DelimitedList(T[] src, char delimiter =  FieldDelimiter)
        {
            Data = src;
            Delimiter = delimiter;
            Render = text.delimit;
        }

        [MethodImpl(Inline)]
        public DelimitedList(T[] src, DelimitArray<T,string> fx, char delimiter = FieldDelimiter)
        {
            Data = src;
            Delimiter = delimiter;
            Render = fx;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render(Data, Delimiter);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator DelimitedList<T>(T[] src)
            => new DelimitedList<T>(src);
    }
}