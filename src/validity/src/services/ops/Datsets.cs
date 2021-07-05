//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class TestContext
    {
        [MethodImpl(Inline)]
        public static int fieldwidth<E>(E field)
            where E : unmanaged, Enum
        {
            var w = core.@as<E,uint>(field) >> 16;
            return (int)w;
        }

        internal readonly struct Datasets
        {
            [Op]
            internal static string render(object content)
            {
                var rendered = string.Empty;
                if(content is null)
                    return Null.Value.Format();
                else if(content is ITextual t)
                    return t.Format();
                else
                    return content.ToString();
            }
        }

        interface IDatasetFormatter : ITextual
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

        interface IDatasetFormatter<F> : IDatasetFormatter
            where F : unmanaged, Enum
        {
            void Append(F f, object content)
            {
                State.Append(Datasets.render(content).PadRight(fieldwidth(f)));
            }

            void Delimit(F f, object content)
            {
                State.Append(RP.rspace(Delimiter));
                State.Append(Datasets.render(content).PadRight(fieldwidth(f)));
            }
        }

        internal readonly struct DatasetFormatter<F> : IDatasetFormatter<F>
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
                State.Append(RP.rspace(Delimiter));
                State.Append(render(content).PadRight(width(f)));
            }

            public void DelimitField(F f, object content, char delimiter)
            {
                State.Append(RP.rspace(delimiter));
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
            {
                var w = core.@as<F,uint>(field) >> 16;
                return (int)w;
            }
        }
    }
}