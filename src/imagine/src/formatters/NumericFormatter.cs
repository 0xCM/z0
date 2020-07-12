//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct NumericFormatter
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<string> items<T>(ReadOnlySpan<T> src)  
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
        public static string format<F>(F src)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src);

        [MethodImpl(Inline)]
        public static string format<F>(F src, NumericBaseKind @base)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src, @base);

        [MethodImpl(Inline)]
        public static INumericFormatter<T> Define<T>(Func<T,string> f, Func<T,NumericBaseKind,string> g)
            where T : unmanaged
                => new FunctionalNumericFormatter<T>(f,g);

        [MethodImpl(Inline)]
        public static INumericFormatter<T> Define<T>(Func<T,NumericBaseKind,string> g)
            where T : unmanaged
                => new FunctionalNumericFormatter<T>(g);
    }
}