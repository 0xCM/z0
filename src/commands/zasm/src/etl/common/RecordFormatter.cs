//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Seed;

    readonly struct RecordFormatter<F> : IRecordFormatter<F>
        where F : unmanaged, Enum
    {        
        readonly StringBuilder State;

        readonly char FieldSep;

        public static IRecordFormatter<F> Service 
            => new RecordFormatter<F>(new StringBuilder());        
        
        [MethodImpl(Inline)]
        RecordFormatter(StringBuilder state, char sep = Chars.Pipe)
        {
            State = state;
            FieldSep = sep;
        }

        public void AppendField(F f, object content)
        {
            State.Append(RenderContent(content).PadRight(Records.Width(f)));
        }

        public void AppendField<T>(F f, T content)
            where T : ITextual
        {
            State.Append($"{content?.Format()}".PadRight(Records.Width(f)));
        }

        public void DelimitField(F f, object content, char delimiter)
        {            
            State.Append(rspace(delimiter));            
            State.Append(RenderContent(content).PadRight(Records.Width(f)));
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

        [MethodImpl(Inline)]
        public void DelimitField(F f, object content)
            => DelimitField(f, content, FieldSep);        

        [MethodImpl(Inline)]
        public void DelimitSome<T>(F f, T content)
            where T : unmanaged, Enum
                => DelimitField(f, content.IsSome() 
                 ? content.ToString() 
                 : string.Empty, FieldSep);        

        public void DelimitField<T>(F f, T content, char delimiter)
            where T : ITextual
        {
            State.Append(rspace(delimiter));            
            State.Append($"{content?.Format()}".PadRight(Records.Width(f)));
        }

        [MethodImpl(Inline)]
        public void DelimitField<T>(F f, T content)
            where T : ITextual
                => DelimitField(f,content, FieldSep);

        public string Render()
            => State.ToString();

        public void Reset()
            => State.Clear();

        static string rspace(object content)
            => $"{content} ";

        public string Format()
            => State.ToString();
        

        public override string ToString()
            => Format();
    }
}