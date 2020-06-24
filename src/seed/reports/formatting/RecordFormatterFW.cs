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
    using System.Collections.Generic;

    using static Konst;

    public readonly struct RecordFormatter<F,W> : IRecordFormatter<F>
        where F : unmanaged, Enum
        where W : unmanaged, Enum
    {        
        readonly StringBuilder State;

        readonly char Delimiter;

        readonly F[] Fields;

        readonly W[] Widths;
        
        [MethodImpl(Inline)]
        public RecordFormatter(StringBuilder state, char delimiter = FieldDelimiter)
        {
            State = state;
            Delimiter = delimiter;
            Fields = Root.literals<F>();
            Widths = Root.literals<W>();
        }

        public ref readonly W this[F field]
        {
            [MethodImpl(Inline)]
            get => ref Widths[Root.e16u(field)];
        }

        [MethodImpl(Inline)]
        public ushort Width(F field)
            => Root.e16u(this[field]);

        public void Append(F f, object content)
        {
            State.Append(Render(content).PadRight(Width(f)));
        }

        public void Append<T>(F f, T content)
            where T : ITextual
        {
            State.Append(Render(content).PadRight(Width(f)));
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
            State.Append(Render(content).PadRight(Width(field)));
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
            State.Append(Render(src).PadRight(Width(field)));
        }

        void DelimitField(F f, object content, char delimiter)
        {            
            State.Append(rspace(delimiter));            
            State.Append(Render(content).PadRight(Width(f)));
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

    }
}