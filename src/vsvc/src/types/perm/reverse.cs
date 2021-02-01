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
        [Closures(Integers), Reverse]
        public readonly struct Reverse128<T> : IUnaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x)
                => gcpu.vreverse(x);
        }

        [Closures(Integers), Reverse]
        public readonly struct Reverse256<T> : IUnaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => gcpu.vreverse(x);
        }
    }

}