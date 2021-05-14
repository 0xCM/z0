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

    using K = ApiClasses;

    partial struct CalcHosts
    {
        [Closures(AllNumeric), Nonz]
        public readonly struct VNonZ128<T> : IUnaryPred128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x)
                => gcpu.vnonz(x);

            [MethodImpl(Inline)]
            public bit Invoke(T a)
                => gmath.nonz(a);
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct VNonZ256<T> : IUnaryPred256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x)
                => gcpu.vnonz(x);

            [MethodImpl(Inline)]
            public bit Invoke(T a)
                => gmath.nonz(a);
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct Nonz<T> : IFunc<T,bit>, SFx.IUnarySpanPred<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(T a)
                => gmath.nonz(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => apply(this, src, dst);
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ128<T> : IBlockedUnaryPred128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<bit> Invoke(in SpanBlock128<T> src, Span<bit> dst)
                => map(src, dst, Calcs.vnonz<T>(w128));
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ256<T> : IBlockedUnaryPred256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<bit> Invoke(in SpanBlock256<T> src, Span<bit> dst)
                => map(src, dst, Calcs.vnonz<T>(w256));
        }
    }
}