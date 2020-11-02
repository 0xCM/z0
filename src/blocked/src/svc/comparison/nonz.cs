
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
        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ128<T> : IBlockedUnaryPred128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<Bit32> Invoke(in SpanBlock128<T> src, Span<Bit32> dst)
                => map(src, dst, VSvc.vnonz<T>(w128));
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ256<T> : IBlockedUnaryPred256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<Bit32> Invoke(in SpanBlock256<T> src, Span<Bit32> dst)
                => map(src, dst, VSvc.vnonz<T>(w256));
        }
    }
}