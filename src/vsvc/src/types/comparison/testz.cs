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
        [Closures(AllNumeric), TestZ]
        public readonly struct TestZ128<T> : IBinaryPred128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x,Vector128<T> y)
                => gcpu.vtestz(x,y);

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b)
                => default;
        }

        [Closures(AllNumeric), TestZ]
        public readonly struct TestZ256<T> : IBinaryPred256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x,Vector256<T> y)
                => gcpu.vtestz(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b)
                => default;
        }
   }
}