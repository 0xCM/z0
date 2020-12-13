//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static double float64<T>(T src)
            => As<T,double>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref double float64<T>(ref T src)
            => ref As<T,double>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static double? float64<T>(T? src)
            where T : unmanaged
                => As<T?, double?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<double> float64<T>(Span<T> src)
            where T : struct
                => recover<T,double>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<double> float64<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,double>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static decimal float128<T>(T src)
            => As<T,decimal>(ref src);
    }
}