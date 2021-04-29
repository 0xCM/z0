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
        [Closures(AllNumeric), Max]
        public readonly struct VMax128<T> : IBinaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
                => gcpu.vmax(x,y);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b)
                => gmath.max(a,b);
        }

        [Closures(AllNumeric), Max]
        public readonly struct VMax256<T> : IBinaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
                => gcpu.vmax(x,y);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b)
                => gmath.max(a,b);
        }
    }
}