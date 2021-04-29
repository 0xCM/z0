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
        [Closures(AllNumeric), Abs]
        public readonly struct Abs<T> : IUnaryOp<T>, IUnarySpanOp<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly T Invoke(T a)
                => gmath.abs(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => Calcs.inc(src,dst);
        }

        [Closures(AllNumeric), Abs]
        public readonly struct Abs128<T> : IBlockedUnaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> src, in SpanBlock128<T> dst)
                => ref map(src, dst, VSvc.vabs<T>(w128));
        }

        [Closures(AllNumeric), Abs]
        public readonly struct Abs256<T> : IBlockedUnaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> src, in SpanBlock256<T> dst)
                => ref map(src, dst, VSvc.vabs<T>(w256));
        }
    }
}