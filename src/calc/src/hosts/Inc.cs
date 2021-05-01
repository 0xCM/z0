//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;

    partial struct CalcHosts
    {
        [Closures(AllNumeric), Inc]
        public readonly struct Inc<T> : IUnaryOp<T>, IUnarySpanOp<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly T Invoke(T a)
                => gmath.inc(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => Calcs.inc(src,dst);
        }

        [NumericClosures(AllNumeric), Inc]
        public readonly struct Inc128<T> : IBlockedUnaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> src, in SpanBlock128<T> dst)
                => ref map(src, dst, Calcs.vinc<T>(w128));
        }

        [NumericClosures(AllNumeric), Inc]
        public readonly struct Inc256<T> : IBlockedUnaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> src, in SpanBlock256<T> dst)
                => ref map(src, dst, Calcs.vinc<T>(w256));
        }

    }
}