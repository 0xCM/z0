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

    public readonly struct RecordFormatter<F> : IRecordFormatter<F>
        where F : unmanaged, Enum
    {        
        readonly StringBuilder State;

        readonly char Delimiter;
        
        [MethodImpl(Inline)]
        public RecordFormatter(StringBuilder state, char delimiter = Tabular.DefaultDelimiter)
        {
            State = state;
            Delimiter = delimiter;
        }

        public void Append(F f, object content)
        {
            State.Append(Render(content).PadRight(Tabular.width(f)));
        }

        public void Append<T>(F f, T content)
            where T : ITextual
        {
            State.Append(Render(content).PadRight(Tabular.width(f)));
        }

        static string Render(ITextual src)
            => src?.Format() ?? string.Empty;

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

        [MethodImpl(Inline)]
        public void Delimit(F field, object content)
        {            
            State.Append(rspace(Delimiter));            
            State.Append(Render(content).PadRight(Tabular.width(field)));
        }

        [MethodImpl(Inline)]
        public void DelimitSome<T>(F field, T src)
            where T : unmanaged, Enum
                => DelimitField(field, src.IsSome()  ? src.ToString() : text.Empty, Delimiter);        

        [MethodImpl(Inline)]
        public void Delimit<T>(F field, T src)
            where T : ITextual
        {
            State.Append(rspace(Delimiter));            
            State.Append(Render(src).PadRight(Tabular.width(field)));
        }

        void DelimitField(F f, object content, char delimiter)
        {            
            State.Append(rspace(delimiter));            
            State.Append(Render(content).PadRight(Tabular.width(f)));
        }

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