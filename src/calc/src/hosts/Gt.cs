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
        [Closures(AllNumeric), Gt]
        public readonly struct Gt<T> : IFunc<T,T,bit>, IBinarySpanPred<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(T a, T b)
                => gmath.gt(a,b);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<bit> dst)
                => apply(this, a,b,dst);
        }

        [Closures(AllNumeric), Gt]
        public readonly struct Gt128<T> : IBlockedBinaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
                => ref zip(a, b, dst, Calcs.vgt<T>(w128));
        }

        [Closures(AllNumeric), Gt]
        public readonly struct Gt256<T> : IBlockedBinaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
                => ref zip(a, b, dst, Calcs.vgt<T>(w256));
        }
    }
}