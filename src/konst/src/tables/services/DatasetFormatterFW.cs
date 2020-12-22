//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DatasetFormatter<F,W> : IDatasetFormatter<F>
        where F : unmanaged, Enum
        where W : unmanaged, Enum
    {
        public StringBuilder State {get;}

        readonly char Delimiter;

        readonly F[] Fields;

        readonly W[] Widths;

        public static implicit operator string(DatasetFormatter<F,W> src)
            => src.Format();

        [MethodImpl(Inline)]
        public DatasetFormatter(StringBuilder state, char delimiter = FieldDelimiter)
        {
            State = state;
            Delimiter = delimiter;
            Fields = Enums.literals<F>();
            Widths = Enums.literals<W>();
        }

        public void EmitHeader(bool eol)
        {
            var header = Table.datasetHeader<F>();
            for(var i=0; i<header.Fields.Length; i++)
                Delimit(header.Fields[i], header.Labels[i]);

            if(eol)
                EmitEol();
        }

        public string FormatHeader()
            => Table.datasetHeader<F>().Render();

        public void EmitHeader()
            => EmitHeader(true);

        public string HeaderText
            => Table.header53<F>();

        public void EmitEol()
        {
            State.Append(Eol);
        }

        public ref readonly W this[F field]
        {
            [MethodImpl(Inline)]
            get => ref Widths[z.uint16(field)];
        }

        [MethodImpl(Inline)]
        public ushort Width(F field)
            => z.uint16(this[field]);

        public void Append(F f, object content)
        {
            State.Append(Render(content).PadRight(Width(f)));
        }

        public void Append<T>(F f, T content)
            where T : ITextual
        {
            State.Append(Render(content).PadRight(Width(f)));
        }

        static string Render(ITextual src)
            => src?.Format() ?? string.Empty;

        static string Render(object content)
        {
            var rendered = string.Empty;
            if(content is null)
                return Null.Value.Format();
            else if(content is ITextual t)
                return Render(t);
            else
                return content.ToString();
        }

        public void Delimit(F field, object content)
        {
            State.Append(rspace(Delimiter));
            State.Append(Render(content).PadRight(Width(field)));
        }

        public void DelimitSome<T>(F field, T src)
            where T : unmanaged, Enum
                => DelimitField(field, src.IsSome()  ? src.ToString() : text.Empty, Delimiter);

        public void Delimit<T>(F field, T src)
            where T : ITextual
        {
            State.Append(rspace(Delimiter));
            State.Append(Render(src).PadRight(Width(field)));
        }

        void DelimitField(F f, object content, char delimiter)
        {
            State.Append(rspace(delimiter));
            State.Append(Render(content).PadRight(Width(f)));
        }

        public string Render(bool clear = true)
        {
            var result = State.ToString();
            if(clear)
                State.Clear();
            return result;
        }

        public void Reset()
            => State.Clear();

        static string rspace(object content)
            => $"{content} ";

        public string Format()
            => State.ToString();

        public override string ToString()
            => Format();
    }
}