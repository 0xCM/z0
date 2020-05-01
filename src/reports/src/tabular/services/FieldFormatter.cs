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
    /// ~ The position of a field, its index, is determined by the lower 32 bits of the enum value
    /// ~ The width of a field is determined by the upper 32 bits of the enum 
    /// </summary>
    enum SampleField : ulong
    {
        Field0 = 0 | (60ul << 32),

        Field1 =  1 | (14ul << 32),

        Field2 = 2  | (14ul << 32),
        
        Feild3 =  3 | (26ul << 32)
    }

    public readonly struct FieldFormatter<E> : ITextual
        where E : unmanaged, Enum
    {        
        readonly StringBuilder State;

        readonly char FieldSep;

        public static FieldFormatter<E> Service => new FieldFormatter<E>(new StringBuilder());        
        
        [MethodImpl(Inline)]
        internal static int width(E spec)
            => (int)(Enums.numeric<E,ulong>(spec) >> 32);

        [MethodImpl(Inline)]
        internal static int index(E spec)
            => (int)Enums.numeric<E,ulong>(spec);

        [MethodImpl(Inline)]
        FieldFormatter(StringBuilder state, char sep = Chars.Pipe)
        {
            State = state;
            FieldSep = sep;
        }

        public void AppendField(E f, object content)
        {
            State.Append($"{content}".PadRight(width(f)));
        }

        public void AppendField<T>(E f, T content)
            where T : ITextual
        {
            State.Append($"{content?.Format()}".PadRight(width(f)));
        }

        public void DelimitField(E f, object content, char delimiter)
        {
            State.Append(rspace(delimiter));            
            State.Append($"{content}".PadRight(width(f)));
        }

        [MethodImpl(Inline)]
        public void DelimitField(E f, object content)
            => DelimitField(f, content, FieldSep);        

        public void DelimitField<T>(E f, T content, char delimiter)
            where T : ITextual
        {
            State.Append(rspace(delimiter));            
            State.Append($"{content?.Format()}".PadRight(width(f)));
        }

        [MethodImpl(Inline)]
        public void DelimitField<T>(E f, T content)
            where T : ITextual
                => DelimitField(f,content, FieldSep);

        /// <summary>
        /// Appends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        static string rspace(object content)
            => $"{content} ";

        public string Format()
            => State.ToString();
        
        public FieldFormatter<E> Reset()
        {
            State.Clear();
            return this;
        }

        public FieldFormatter<E> WithDelimiter(char delimiter)
            => new FieldFormatter<E>(State, delimiter);


        public override string ToString()
            => Format();
    }
}