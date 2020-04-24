//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class VSvcHosts
    {
        [Closures(AllNumeric), TestC]
        public readonly struct TestC128<T> : IBinaryPred128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x, Vector128<T> y) => gvec.vtestc(x,y);

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) => default;
        }

        [Closures(AllNumeric), TestC]
        public readonly struct TestC256<T> : IBinaryPred256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x, Vector256<T> y) => gvec.vtestc(x,y);

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) => default;
        }
    }
}