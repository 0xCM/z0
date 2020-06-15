//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Seed;

    /// <summary>
    /// ~ The name of a field is determined by the enum literal identifier
    /// ~ The position of a field, its index, is determined by the lower 16 bits of the enum value
    /// ~ The width of a field is determined by the upper 16 bits of the enum 
    /// </summary>
    enum SampleField : uint
    {
        Field0 = 0 | (60u << 32),

        Field1 =  1 | (14u << 32),

        Field2 = 2  | (14u << 32),
        
        Feild3 =  3 | (26u << 32)
    }

    public struct FieldFormatter<E> : ITextual
        where E : unmanaged, Enum
    {        
        char Delimiter;

        readonly StringBuilder Target;
        
        public static FieldFormatter<E> Default 
            => new FieldFormatter<E>(new StringBuilder(), Tabular.DefaultDelimiter);        
        
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
            Delimiter = delimiter ?? Tabular.DefaultDelimiter;
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
                => content?.Format() ?? text.Empty;
    }
}