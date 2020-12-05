//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Render
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<string> numeric<T>(ReadOnlySpan<T> src, Base16 @base, Span<string> dst)
            where T : unmanaged
        {
            var formatter = Formatters.numeric<T>();
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst, i) = formatter.Format(skip(src,i), NumericBaseKind.Base16);
            return dst;
        }

    }
}