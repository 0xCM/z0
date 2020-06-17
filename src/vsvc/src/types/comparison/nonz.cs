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

    partial class VSvcHosts
    {
        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ128<T> : IUnaryPred128D<T>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x) => gvec.vnonz(x);

            [MethodImpl(Inline)]
            public bit Invoke(T a) => gmath.nonz(a);
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ256<T> : IUnaryPred256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x) => gvec.vnonz(x);

            [MethodImpl(Inline)]
            public bit Invoke(T a) => gmath.nonz(a);

        }
    }
}