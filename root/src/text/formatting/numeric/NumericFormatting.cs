//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class NumericFormatting
    {
         [MethodImpl(Inline)]
        public static string Format<F>(this F src)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src);

        [MethodImpl(Inline)]
        public static string Format<F>(this F src, NumericBase @base)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src, @base);
    }
}