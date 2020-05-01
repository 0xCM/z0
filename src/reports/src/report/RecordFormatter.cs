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

    public readonly struct RecordFormatter<F,R> : ITextual<RecordFormatter<F,R>>
        where F : unmanaged, Enum
        where R : IRecord<F,R>
    {        
        readonly StringBuilder Builder;

        readonly ReportInfo Report;
        
        /// <summary>
        /// Appends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        static string rspace(object content)
            => $"{content} ";

        [MethodImpl(Inline)]
        internal RecordFormatter(ReportInfo report)
        {
            this.Report = report;
            this.Builder = new StringBuilder();
        }

        public void AppendField(F f, object content)
        {
            Builder.Append($"{content}".PadRight(Reports.width(f)));
        }

        public void DelimitField(F f, object content, char delimiter)
        {
            Builder.Append(rspace(delimiter));            
            Builder.Append($"{content}".PadRight(Reports.width(f)));
        }

        public void AppendField<T>(F f, T content)
            where T : ITextual
        {
            Builder.Append($"{content?.Format()}".PadRight(Reports.width(f)));
        }

        public void DelimitField<T>(F f, T content, char delimiter)
            where T : ITextual
        {
            Builder.Append(rspace(delimiter));            
            Builder.Append($"{content?.Format()}".PadRight(Reports.width(f)));
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