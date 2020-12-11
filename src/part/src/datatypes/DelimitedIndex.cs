//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static FormatFunctions;

    public readonly struct DelimitedIndex<T> : IIndex<T>, ITextual
    {
        public readonly T[] Data;

        public readonly char Delimiter;

        readonly DelimitArray<T,string> Render;

        [MethodImpl(Inline)]
        public DelimitedIndex(T[] src, char delimiter =  FieldDelimiter)
        {
            Data = src;
            Delimiter = delimiter;
            Render = text.delimit;
        }

        [MethodImpl(Inline)]
        public DelimitedIndex(T[] src, DelimitArray<T,string> fx, char delimiter = FieldDelimiter)
        {
            Data = src;
            Delimiter = delimiter;
            Render = fx;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render(Data, Delimiter);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator DelimitedIndex<T>(T[] src)
            => new DelimitedIndex<T>(src);
    }
}