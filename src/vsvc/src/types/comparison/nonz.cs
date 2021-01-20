//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static SFx;

    partial class VServices
    {
        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ128<T> : IUnaryPred128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Bit32 Invoke(Vector128<T> x)
                => gcpu.vnonz(x);

            [MethodImpl(Inline)]
            public Bit32 Invoke(T a)
                => gmath.nonz(a);
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ256<T> : IUnaryPred256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Bit32 Invoke(Vector256<T> x)
                => gcpu.vnonz(x);

            [MethodImpl(Inline)]
            public Bit32 Invoke(T a)
                => gmath.nonz(a);
        }
    }
}