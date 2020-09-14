//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Konst;
    using static Datasets;

    public interface IDatasetFormatter : ITextual
    {
        StringBuilder State {get;}

        string HeaderText {get;}

        string[] Labels {get;}

        void EmitHeader(bool eol = true);

        char Delimiter
            => FieldDelimiter;

        string Render(bool reset = true)
        {
            var result = State.ToString();
            if(reset)
                State.Clear();
            return result;
        }

        void Reset()
            => State.Clear();

        string ITextual.Format()
            => State.ToString();

        void EmitEol()
        {
            State.Append(Eol);
        }
    }

    public interface IDatasetFormatter<F> : IDatasetFormatter
        where F : unmanaged, Enum
    {
        string IDatasetFormatter.HeaderText
            => header<F>().Render(Delimiter);

        string[] IDatasetFormatter.Labels
            => Table.index<F>().Names;

        void Append(F f, object content)
        {
            State.Append(Datasets.render(content).PadRight(width(f)));
        }

        void Delimit(F f, object content)
        {
            State.Append(text.rspace(Delimiter));
            State.Append(Datasets.render(content).PadRight(width(f)));
        }

        void IDatasetFormatter.EmitHeader(bool eol)
        {
            var header = header<F>();
            for(var i=0; i<header.Fields.Length; i++)
            {
                if(i == 0)
                    Append(header.Fields[i], header.Labels[i]);
                else
                    Delimit(header.Fields[i], header.Labels[i]);
            }

            if(eol)
                State.Append(Eol);
        }

        void Append<T>(F f, T content)
            where T : ITextual
        {
            State.Append(Datasets.render(content).PadRight(width(f)));
        }

        void Delimit<T>(F f, T content)
            where T : ITextual
        {
            State.Append(text.rspace(Delimiter));
            State.Append(Datasets.render(content).PadRight(width(f)));
        }

        void DelimitSome<T>(F f, T src)
            where T : unmanaged, Enum
                => DelimitField(f, src.IsSome()  ? src.ToString() : text.Empty, Delimiter);

        void DelimitField(F f, object content, char delimiter)
        {
            State.Append(text.rspace(delimiter));
            State.Append(Datasets.render(content).PadRight(width(f)));
        }
    }
}