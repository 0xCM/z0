//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    public struct DatasetFieldFormatter<F>
        where F : unmanaged, Enum
    {
        readonly StringBuilder Target;

        char Delimiter;

        [MethodImpl(Inline)]
        public DatasetFieldFormatter(StringBuilder dst, char delimiter = FieldDelimiter)
        {
            z.insist(dst != null);
            Target = dst;
            Delimiter = delimiter;
        }

        public void EmitEol()
            => Target.Append(Eol);

        public void Append(F f, object content)
        {
            z.insist(content != null);
            Target.Append(Render(content).PadRight(Datasets.width(f)));
        }

        public void Delimit(F f, object content)
        {
            z.insist(content != null);
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(content).PadRight(Datasets.width(f)));
        }

        public void Delimit<T>(F f, T content)
            where T : ITextual
        {
            z.insist(content != null);
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
            z.insist(Target != null);
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