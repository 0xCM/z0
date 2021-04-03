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

    using static Part;

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
    }
}