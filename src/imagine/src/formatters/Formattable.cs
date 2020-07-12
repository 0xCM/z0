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

    using static Konst;
    using static z;
        
    [ApiHost]
    public readonly struct Formattable
    {
        public static ReadOnlySpan<string> items<T>(ReadOnlySpan<T> src)            
            where T : ITextual
        {
            var count = src.Length;
            var dst = z.span<string>(count);
            for(var i=0u; i<count; i++)
                z.seek(dst, i) = skip(src,i).Format();
            return dst;
        }        

        public static string format<T>(ReadOnlySpan<T> src, string delimiter)            
            where T : ITextual
                => items(src).Concat(delimiter);

        public static IEnumerable<string> items<F>(IEnumerable<F> items)
            where F : ITextual
                => items.Select(m => m.Format());                
    }
}