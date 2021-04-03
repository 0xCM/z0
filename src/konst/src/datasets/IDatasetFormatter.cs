//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Part;
    using static Datasets;

    public interface IDatasetFormatter : ITextual
    {
        StringBuilder State {get;}

        char Delimiter
            => FieldDelimiter;

        string Render(bool reset = true)
        {
            var result = State.ToString();
            if(reset)
                State.Clear();
            return result;
        }

        string ITextual.Format()
            => State.ToString();
    }

    public interface IDatasetFormatter<F> : IDatasetFormatter
        where F : unmanaged, Enum
    {
        void Append(F f, object content)
        {
            State.Append(Datasets.render(content).PadRight(width(f)));
        }

        void Delimit(F f, object content)
        {
            State.Append(text.rspace(Delimiter));
            State.Append(Datasets.render(content).PadRight(width(f)));
        }

        void DelimitField(F f, object content, char delimiter)
        {
            State.Append(text.rspace(delimiter));
            State.Append(Datasets.render(content).PadRight(width(f)));
        }
    }
}