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

    public struct FieldFormatter<E> : ITextual
        where E : unmanaged, Enum
    {        

        readonly StringBuilder Target;
        
        char Delimiter;

        public static FieldFormatter<E> Default 
            => new FieldFormatter<E>(new StringBuilder(), FieldDelimiter);        
        
        [MethodImpl(Inline)]
        FieldFormatter(StringBuilder dst, char delimiter)
        {
            Target = dst;
            Delimiter = delimiter;
        }

        public void Append(E f, object content)
            => Target.Append(Render(content).PadRight(Tabular.width(f)));

        public void Append<T>(E f, T content)
            where T : ITextual
                => Target.Append(Render(content).PadRight(Tabular.width(f)));

        public void Delimit(E f, object content)
        {            
            Target.Append(text.spaced(Delimiter));            
            Target.Append(Render(content).PadRight(Tabular.width(f)));
        }

        public void Delimit<T>(E f, T content)
            where T : ITextual
        {
            Target.Append(text.spaced(Delimiter));            
            Target.Append(Render(content).PadRight(Tabular.width(f)));
        }

        public FieldFormatter<E> Reset(char? delimiter = null)
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