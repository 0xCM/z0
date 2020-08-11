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

    using Z0.Data;
    public struct TableFormatter<F,T> : ITableFormatter<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
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
        
        void Append(F f, object content)
            => Target.Append(Render(content).PadRight(Fields.Width(f)));

        void Delimit(F f, object content)
        {            
            Target.Append(Delimiter);
            Target.Append(Space);            
            Target.Append(Render(content).PadRight(Fields.Width(f)));
        }

        void Delimit(F f, T content)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(content).PadRight(Fields.Width(f)));
        }

        public TableFormatter<F,T> Reset()
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
                return t.Format();
            else
                return content.ToString();
        }

        public string FormatRow(in T src)
        {
            throw new NotImplementedException();
        }

        public string FormatHeader()
        {
            throw new NotImplementedException();
        }
    }
}