//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial struct Formatters
    {   
        [Op, Closures(AllNumeric)]
        public static ReadOnlySpan<string> cells<T>(Formatter<T> formatter, ReadOnlySpan<T> src)
        {
            var dst = Spans.alloc<string>(src.Length);
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = cell(formatter, skip(src,i));            
            return dst;
        }
    }
}