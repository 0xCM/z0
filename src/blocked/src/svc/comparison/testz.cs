
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
    using static SFx;

    partial class BSvcHosts
    {
        [Closures(AllNumeric), TestZ]
        public readonly struct TestZ128<T> : IBlockedBinaryPred128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<bit> Invoke(in SpanBlock128<T> a, in SpanBlock128<T> b, Span<bit> dst)
                => zip(a, b, dst, VSvc.vtestz<T>(w128));
        }

        [Closures(AllNumeric), TestZ]
        public readonly struct TestZ256<T> : IBlockedBinaryPred256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<bit> Invoke(in SpanBlock256<T> a, in SpanBlock256<T> b, Span<bit> dst)
                => zip(a, b, dst, VSvc.vtestz<T>(w256));
        }
    }
}