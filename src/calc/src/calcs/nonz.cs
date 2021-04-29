//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static SFx;

    partial struct Calcs
    {
        [MethodImpl(Inline)]
        public static NonZ128<T> nonz<T>(W128 w)
            where T : unmanaged
                => default(NonZ128<T>);

        [MethodImpl(Inline)]
        public static NonZ256<T> nonz<T>(W256 w)
            where T : unmanaged
                => default(NonZ256<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Nonz<T> nonz<T>()
            where T : unmanaged
                => default(Nonz<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> nonz<T>(in SpanBlock128<T> a, Span<bit> dst)
            where T : unmanaged
                => nonz<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> nonz<T>(in SpanBlock256<T> a, Span<bit> dst)
            where T : unmanaged
                => nonz<T>(w256).Invoke(a, dst);
    }
}