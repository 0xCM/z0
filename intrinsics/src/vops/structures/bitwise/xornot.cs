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

    partial class VOpTypes
    {
        public readonly struct XorNot128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public static XorNot128<T> Op => default;

            public string Moniker => moniker<N128,T>("vxornot");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vxornot(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xornot(a,b);
        }

        public readonly struct XorNot256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public static XorNot256<T> Op => default;

            public string Moniker => moniker<N256,T>("vxornot");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vxornot(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xornot(a,b);
        }

    }
}