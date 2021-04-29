
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
        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ128<T> : IBlockedUnaryPred128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<bit> Invoke(in SpanBlock128<T> src, Span<bit> dst)
                => map(src, dst, VSvc.vnonz<T>(w128));
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ256<T> : IBlockedUnaryPred256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<bit> Invoke(in SpanBlock256<T> src, Span<bit> dst)
                => map(src, dst, VSvc.vnonz<T>(w256));
        }
    }
}