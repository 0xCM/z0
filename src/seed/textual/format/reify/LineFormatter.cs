//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LineFormatter<T>
    {
        readonly IFormatter<T> CellFormatter;
        
        [MethodImpl(Inline)]
        public LineFormatter(IFormatter<T> f)
            => this.CellFormatter = f;

        [MethodImpl(Inline)]
        public string Format(T src)
            => CellFormatter.Format(src);
        
        public string[] FormatLines(ReadOnlySpan<T> src)
        {
            var dst = new string[src.Length];
            for(var i=0; i< src.Length; i++)
                dst[i] = CellFormatter.Format(src[i]);
            return dst;
        }
    }
}