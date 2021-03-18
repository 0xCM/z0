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

    partial class VSvcHosts
    {
        [Closures(AllNumeric), Negate]
        public readonly struct Negate128<T> : IUnaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x)
                => gcpu.vnegate(x);

            [MethodImpl(Inline)]
            public T Invoke(T a)
                => gmath.negate(a);
        }

        [Closures(AllNumeric), Negate]
        public readonly struct Negate256<T> : IUnaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => gcpu.vnegate(x);

            [MethodImpl(Inline)]
            public T Invoke(T a)
                => gmath.negate(a);
        }
    }
}