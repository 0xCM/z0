
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    partial struct CalcHosts
    {
        [Closures(AllNumeric), TestC]
        public readonly struct TestC128<T> : IBlockedBinaryPred128<T>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in SpanBlock128<T> a, in SpanBlock128<T> b, Span<bit> dst)
                => zip(a, b, dst, Calcs.vtestc<T>(w128));
        }

        [Closures(AllNumeric), TestC]
        public readonly struct TestC256<T> : IBlockedBinaryPred256<T>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in SpanBlock256<T> a, in SpanBlock256<T> b, Span<bit> dst)
                => zip(a, b, dst, Calcs.vtestc<T>(w256));
        }
    }
}