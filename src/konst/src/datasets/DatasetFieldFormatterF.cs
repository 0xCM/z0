//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    public struct DatasetFieldFormatter<F>
        where F : unmanaged, Enum
    {
        readonly StringBuilder Target;

        char Delimiter;

        [MethodImpl(Inline)]
        public DatasetFieldFormatter(StringBuilder dst, char delimiter = FieldDelimiter)
        {
            root.require(dst);
            Target = dst;
            Delimiter = delimiter;
        }

        public void EmitEol()
            => Target.Append(Eol);

        public void Append(F f, object content)
        {
            root.require(content);
            Target.Append(Render(content).PadRight(Datasets.width(f)));
        }

        public void Delimit(F f, object content)
        {
            root.require(content);
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(content).PadRight(Datasets.width(f)));
        }

        public void Delimit<T>(F f, T content)
            where T : ITextual
        {
            root.require(content as ITextual);
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(content).PadRight(Datasets.width(f)));
        }

        public DatasetFieldFormatter<F> Reset(char? delimiter = null)
        {
            Target.Clear();
            Delimiter = delimiter ?? FieldDelimiter;
            return this;
        }

        [MethodImpl(Inline)]
        public string Format()
        {
            root.require(Target);
            return Target.ToString();
        }

        public string Emit()
        {
            var x =  Target.ToString();
            Reset();
            return x;
        }


        public override string ToString()
            => Format();

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

        static string Render<T>(T content)
            where T : ITextual
                => content?.Format() ?? EmptyString;
    }
}