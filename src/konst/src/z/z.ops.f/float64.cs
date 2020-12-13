//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static double float64<T>(T src)
            => memory.float64(src);

        [MethodImpl(Inline)]
        public static ref double float64<T>(ref T src)
            => ref memory.float64(ref src);

        [MethodImpl(Inline)]
        public static double? float64<T>(T? src)
            where T : unmanaged
                => memory.float64(src);

        [MethodImpl(Inline)]
        public static Span<double> float64<T>(Span<T> src)
            where T : struct
                => memory.float64(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> float64<T>(ReadOnlySpan<T> src)
            where T : struct
                => memory.float64(src);
    }
}