//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    public struct TableFormatter<F>
        where F : unmanaged, Enum
    {        
        readonly StringBuilder Target;
        
        readonly LiteralFields<F> Fields;
        
        char Delimiter;

        [MethodImpl(Inline)]
        public TableFormatter(LiteralFields<F> fields, StringBuilder dst = null, char delimiter = FieldDelimiter)
        {
            Fields = fields;
            Target = dst ?? text.build();
            Delimiter = delimiter;
        }

        public void EmitEol()
            => Target.Append(Eol);        
        
        public void Append(F f, object content)
            => Target.Append(Render(content).PadRight(Fields.Width(f)));

        public void Delimit(F f, object content)
        {            
            Target.Append(Delimiter);
            Target.Append(Space);            
            Target.Append(Render(content).PadRight(Fields.Width(f)));
        }

        public void Delimit<T>(F f, T content)
            where T : ITextual
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(content).PadRight(Fields.Width(f)));
        }

        public TableFormatter<F> Reset()
        {            
            Target.Clear();
            return this;
        }

        public string Format()
            => Target.ToString();
        

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