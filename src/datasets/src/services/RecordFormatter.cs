//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct RecordFormatter  
    {
        [MethodImpl(Inline)]
        public static RecordFormatter<F> Create<F>()
            where F : unmanaged, Enum
                =>  new RecordFormatter<F>(new StringBuilder());

    }

    public readonly struct RecordFormatter<F> : IRecordFormatter<F>
        where F : unmanaged, Enum
    {        
        readonly StringBuilder State;

        readonly char FieldSep;
        
        [MethodImpl(Inline)]
        public RecordFormatter(StringBuilder state, char sep = Chars.Pipe)
        {
            State = state;
            FieldSep = sep;
        }

        public void AppendField(F f, object content)
        {
            State.Append(RenderContent(content).PadRight(Width(f)));
        }

        public void AppendField<T>(F f, T content)
            where T : ITextual
        {
            State.Append($"{content?.Format()}".PadRight(Width(f)));
        }

        public void DelimitField(F f, object content, char delimiter)
        {            
            State.Append(rspace(delimiter));            
            State.Append(RenderContent(content).PadRight(Width(f)));
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

        [MethodImpl(Inline)]
        public void DelimitSome<T>(F f, T content, char delimiter)
            where T : unmanaged, Enum
                => DelimitField(f, content.IsSome()  ? content.ToString()  : string.Empty, delimiter);        

        public void DelimitField<T>(F f, T content, char delimiter)
            where T : ITextual
        {
            State.Append(rspace(delimiter));            
            State.Append($"{content?.Format()}".PadRight(Width(f)));
        }

        [MethodImpl(Inline)]
        public void DelimitField<T>(F f, T content)
            where T : ITextual
                => DelimitField(f,content, FieldSep);

        [MethodImpl(Inline)]
        short Width(F spec)
            => (short)(Enums.scalar<F,uint>(spec) >> 16);

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


        [MethodImpl(Inline)]
        static string Render(bool src)
            => src ? CharText.D1 : CharText.D0;
        
        [MethodImpl(Inline)]
        static string RenderHex(string src)
            => src.RemoveBlanks().BlockPartition(2,Chars.Space);
        
        [MethodImpl(Inline)]
        static string RenderHex16(ushort src)
            => src == 0 ? string.Empty : src.FormatHex(true,false);

        [MethodImpl(Inline)]
        static string RenderHex32(uint src)
            => src == 0 ? string.Empty : src.FormatHex(false,true, prespec:false);

        [MethodImpl(Inline)]
        static string RenderHex64(ulong src)
            => src == 0 ? string.Empty : src.FormatHex(false,false);

    }
}