//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Data;

    public readonly struct DatasetFormatter<F> : IDatasetFormatter<F>
        where F : unmanaged, Enum
    {
        public readonly StringBuilder State;

        public readonly char Delimiter;

        public static implicit operator string(DatasetFormatter<F> src)
            => src.ToString();

        [MethodImpl(Inline)]
        public DatasetFormatter(StringBuilder state, char delimiter = FieldDelimiter)
        {
            State = state;
            Delimiter = delimiter;
        }

        public string HeaderText
            => header().Render(Delimiter);

        public string[] Labels
            => labels();

        [MethodImpl(Inline)]
        public int Index(F field)
            => index(field);

        [MethodImpl(Inline)]
        public int Width(F field)
            => width(field);

        [MethodImpl(Inline)]
        public void Reset()
            => State.Clear();

        [MethodImpl(Inline)]
        public void EmitEol()
        {
            State.Append(Eol);
        }

        [MethodImpl(Inline)]
        public string Render(bool reset = true)
        {
            var result = State.ToString();
            if(reset)
                State.Clear();
            return result;
        }

        [MethodImpl(Inline)]
        public void Append(F f, object content)
        {
            State.Append(render(content).PadRight(width(f)));
        }

        [MethodImpl(Inline)]
        public void Delimit(F f, object content)
        {
            State.Append(text.rspace(Delimiter));
            State.Append(render(content).PadRight(width(f)));
        }

        public void EmitHeader(bool eol)
        {
            var h = header();
            for(var i=0; i<h.Fields.Length; i++)
            {
                if(i == 0)
                    Append(h.Fields[i], h.Labels[i]);
                else
                    Delimit(h.Fields[i], h.Labels[i]);
            }

            if(eol)
                State.Append(Eol);
        }

        public void Append<T>(F f, T content)
            where T : ITextual
        {
            State.Append(render(content).PadRight(width(f)));
        }

        public void Delimit<T>(F f, T content)
            where T : ITextual
        {
            State.Append(text.rspace(Delimiter));
            State.Append(render(content).PadRight(width(f)));
        }

        public void DelimitSome<T>(F f, T src)
            where T : unmanaged, Enum
                => DelimitField(f, src.IsSome()  ? src.ToString() : text.Empty, Delimiter);

        public void DelimitField(F f, object content, char delimiter)
        {
            State.Append(text.rspace(delimiter));
            State.Append(render(content).PadRight(width(f)));
        }

        StringBuilder IDatasetFormatter.State
            => State;

        char IDatasetFormatter.Delimiter
            => FieldDelimiter;

        public override string ToString()
            => State.ToString();

        static string render(object content)
        {
            var rendered = string.Empty;
            if(content is null)
                return Null.Value.Format();
            else if(content is ITextual t)
                return t.Format();
            else
                return content.ToString();
        }

        /// <summary>
        /// Computes the field index from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        static int index(F field)
            => (int)(Tabular.PosMask & Enums.e32u(field));

        /// <summary>
        /// Computes the field width from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        static int width(F field)
            => text.width(field);

        [MethodImpl(Inline)]
        static DatasetHeader<F> header()
            => default;

        [MethodImpl(Inline)]
        static string[] labels()
            => Z0.Table.index<F>().Names;
    }
}