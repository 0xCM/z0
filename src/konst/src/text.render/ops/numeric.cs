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
        public static ReadOnlySpan<string> numeric<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var formatter = Formatters.numeric<T>();
            var count = src.Length;
            var dst = z.span<string>(count);
            for(var i=0u; i<count; i++)
                z.seek(dst, i) = formatter.Format(z.skip(src,i), NumericBaseKind.Base16);
            return dst;
        }

        [MethodImpl(Inline)]
        public static string numeric<F>(F src)
            where F : unmanaged, INumericFormattable<F>
                => src.Formatter.Format(src);

        [MethodImpl(Inline)]
        public static string numeric<F>(F src, NumericBaseKind @base)
            where F : unmanaged, INumericFormattable<F>
                => src.Formatter.Format(src, @base);
    }
}