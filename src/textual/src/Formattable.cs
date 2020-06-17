//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using static Konst;
        
    public static class Formattable
    {
        [MethodImpl(Inline)]
        public static string format<T>(ReadOnlySpan<T> src, string delimiter = null)
            where T : ITextual
                => span<T>(delimiter).Format(src);

        public static IEnumerable<string> items<F>(IEnumerable<F> items)
            where F : ITextual
                => items.Select(m => m.Format());                

        [MethodImpl(Inline)]
        static SpanFormatter<T> span<T>(string delimiter = null)
            where T : ITextual
                => new SpanFormatter<T>(SeqFormatConfig.Define(delimiter ?? DefaultSeqFormatConfig.Default.Delimiter));
    }
}