//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct VnonzOp128<T> : IVUnaryPred128<T>
        where T : unmanaged
    {
        public static VnonzOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vnonz");

        [MethodImpl(Inline)]
        public bit Invoke(Vector128<T> x)
            => ginx.vnonz(x);

        [MethodImpl(Inline)]
        public bit InvokeScalar(T a)
            => gmath.nonz(a);
    }

    public readonly struct VnonzOp256<T> : IVUnaryPred256<T>
        where T : unmanaged
    {
        public static VnonzOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vnonz");

        [MethodImpl(Inline)]
        public bit Invoke(Vector256<T> x)
            => ginx.vnonz(x);

        [MethodImpl(Inline)]
        public bit InvokeScalar(T a)
            => gmath.nonz(a);
    }

    partial class VOps
    {
    }
}