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
    using static memory;
    using static SFx;

    partial struct Calcs
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static TestC128<T> testc<T>(W128 w)
            where T : unmanaged
                => default(TestC128<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static TestC256<T> testc<T>(W256 w)
            where T : unmanaged
                => default(TestC256<T>);


        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> testc<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, Span<bit> dst)
            where T : unmanaged
                => testc<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> testc<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, Span<bit> dst)
            where T : unmanaged
                => testc<T>(w256).Invoke(a, b, dst);
    }
}