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

    public readonly struct VnegateOp128<T> : IVUnaryOp128<T>
        where T : unmanaged
    {
        public static VnegateOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vnegate");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x)
            => ginx.vnegate(x);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a)
            => gmath.negate(a);
    }

    public readonly struct VnegateOp256<T> : IVUnaryOp256<T>
        where T : unmanaged
    {
        public static VnegateOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vnegate");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x)
            => ginx.vnegate(x);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a)
            => gmath.negate(a);
    }

    partial class VOps
    {
    }

}