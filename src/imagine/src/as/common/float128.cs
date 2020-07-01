//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref decimal float128<T>(in T src)
            => ref As<T,decimal>(ref edit(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static decimal? float128<T>(T? src)
            where T : unmanaged
                => As<T?, decimal?>(ref src);            

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<decimal> float128<T>(Span<T> src)
            where T : struct
                => cast<T,decimal>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<decimal> float128<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,decimal>(src);
    }
}