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
    using static FieldFormat;

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
        const char DefaultDelimiter = Chars.Pipe;
        
        public static FieldFormatter<E> Default 
            => new FieldFormatter<E>(new StringBuilder(), DefaultDelimiter);        

        public static FieldFormatter<E> Create(StringBuilder dst, char? delimiter = null)
            => new FieldFormatter<E>(new StringBuilder(), delimiter ?? DefaultDelimiter);        

        public static FieldFormatter<E> Create(char? delimiter = null)
            => new FieldFormatter<E>(new StringBuilder(), delimiter ?? DefaultDelimiter);        
        
        readonly StringBuilder Target;

        char Delimiter;
        
        [MethodImpl(Inline)]
        FieldFormatter(StringBuilder dst, char delimiter)
        {
            Target = dst;
            Delimiter = delimiter;
        }

        public void Append(E f, object content)
        {
            Target.Append(RenderContent(content).PadRight(width(f)));
        }

        public void Append<T>(E f, T content)
            where T : ITextual
        {
            Target.Append($"{content?.Format()}".PadRight(width(f)));
        }

        static string RenderContent(object content)
        {
            var rendered = string.Empty;
            if(content is null)
                rendered = Null.Value.Format();
            else if(content is ITextual t)
                rendered = t.Format();
            else
                rendered = content.ToString();
            return rendered;
        }

        public void Delimit(E f, object content)
        {            
            Target.Append(text.spaced(Delimiter));            
            Target.Append(RenderContent(content).PadRight(width(f)));
        }

        public void Delimit<T>(E f, T content)
            where T : ITextual
        {
            Target.Append(text.spaced(Delimiter));            
            Target.Append($"{content?.Format()}".PadRight(text.padding(f)));
        }

        /// <summary>
        /// Appends a field with an enum value if nonzero; othewise, appends the empty string
        /// </summary>
        /// <param name="f">The field</param>
        /// <param name="content">The field content</param>
        /// <typeparam name="T">The enum content type</typeparam>
        public void DelimitSome<T>(E f, T content)
            where T : unmanaged, Enum
        {
            var value = content.IsSome() ? content.ToString() : string.Empty;            
            Target.Append(text.spaced(Delimiter));            
            Target.Append(RenderContent(value).PadRight(width(f)));
        }

        public string Format()
            => Target.ToString();
        
        public FieldFormatter<E> Reset(char? delimiter = null)
        {            
            Target.Clear();
            Delimiter = delimiter ?? DefaultDelimiter;
            return this;
        }


        public override string ToString()
            => Format();
    }
}