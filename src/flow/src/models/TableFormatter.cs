//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Reflection;

    using static Konst;

    public struct TableFormatter<F> : ITableFormatter<F>
        where F : unmanaged, Enum
    {        
        readonly StringBuilder Target;
        
        char Delimiter;

        readonly FieldInfo[] Fields;

        [MethodImpl(Inline)]
        public TableFormatter(StringBuilder dst, char delimiter)
        {
            Target = dst;
            Delimiter = delimiter;
            Fields = typeof(F).LiteralFields();
        }

        [MethodImpl(Inline)]
        static ushort width(F field)
            =>  z.scalar<F,ushort>(field);

        [MethodImpl(Inline)]
        static ushort width(FieldInfo field)
            =>  z.scalar<F,ushort>((F)field.GetRawConstantValue());

        public void EmitEol()
            => Target.Append(Eol);        
        
        public void EmitHeader()
        {
            for(var i=0; i<Fields.Length; i++)
            {
                if(i != 0)
                {
                    Target.Append(Delimiter);
                    Target.Append(Space);
                }

                ref readonly var field = ref Fields[i];
                Target.Append(field.Name.PadRight(width(field)));
            }
            
            EmitEol();
        }

        public void Append(F f, object content)
            => Target.Append(Render(content).PadRight(width(f)));

        public void Delimit(F f, object content)
        {            
            Target.Append(Delimiter);
            Target.Append(Space);            
            Target.Append(Render(content).PadRight(width(f)));
        }

        public void Delimit<T>(F f, T content)
            where T : ITextual
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(content).PadRight(width(f)));
        }

        public TableFormatter<F> Reset(char? delimiter = null)
        {            
            Target.Clear();
            Delimiter = delimiter ?? FieldDelimiter;
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