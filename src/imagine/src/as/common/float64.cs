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

    partial struct AsDeprecated
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
    }
}