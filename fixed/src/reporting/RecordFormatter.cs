//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    public readonly struct RecordFormatter<F,R> : IFormattable<RecordFormatter<F,R>>
        where F : unmanaged, Enum
        where R : IRecord<F, R>
    {
        
        readonly StringBuilder Builder;

        readonly ReportInfo Report;
        

        [MethodImpl(Inline)]
        static int width(F f)
            => Reports.width(f);

        [MethodImpl(Inline)]
        internal RecordFormatter(ReportInfo report)
        {
            this.Report = report;
            this.Builder = new StringBuilder();
        }

        public void AppendField(F f, object content)
        {
            Builder.Append($"{content}".PadRight(width(f)));
        }

        public void DelimitField(F f, object content, char delimiter)
        {
            Builder.Append(text.rspace(delimiter));            
            Builder.Append($"{content}".PadRight(width(f)));
        }

        public void AppendField<T>(F f, T content)
            where T : ICustomFormattable
        {
            Builder.Append($"{content?.Format()}".PadRight(width(f)));
        }

        public void DelimitField<T>(F f, T content, char delimiter)
            where T : ICustomFormattable
        {
            Builder.Append(text.rspace(delimiter));            
            Builder.Append($"{content?.Format()}".PadRight(width(f)));
        }

        public string Format()
            => Builder.ToString();
        
        public RecordFormatter<F,R> Reset()
        {
            Builder.Clear();
            return this;
        }

        public override string ToString()
            => Format();
    }
}