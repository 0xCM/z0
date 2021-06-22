//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static FormatFunctions;

    partial class XTend
    {
        public static DelimitedIndex<T> Delimited<T>(this T[] src, char delimiter = Chars.Comma)
            => new DelimitedIndex<T>(src, delimiter);
    }

    public readonly struct DelimitedIndex<T> : IIndex<T>, ITextual
    {
        public Index<T> Data {get;}

        public char Delimiter {get;}

        public int CellPad {get;}

        readonly FormatCells<T> Render;

        [MethodImpl(Inline)]
        public DelimitedIndex(Index<T> src, char delimiter = FieldDelimiter, int pad = 0)
        {
            Data = src;
            Delimiter = delimiter;
            Render = TextTools.delimit;
            CellPad = pad;
        }

        [MethodImpl(Inline)]
        public DelimitedIndex(T[] src, char delimiter = FieldDelimiter, int pad = 0)
        {
            Data = src;
            Delimiter = delimiter;
            Render = TextTools.delimit;
            CellPad = pad;
        }

        [MethodImpl(Inline)]
        public DelimitedIndex(T[] src, FormatCells<T> fx, char delimiter = FieldDelimiter, int pad = 0)
        {
            Data = src;
            Delimiter = delimiter;
            Render = fx;
            CellPad = pad;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render(Data, Delimiter, CellPad);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator DelimitedIndex<T>(T[] src)
            => new DelimitedIndex<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator DelimitedIndex<T>(Index<T> src)
            => new DelimitedIndex<T>(src);
    }
}