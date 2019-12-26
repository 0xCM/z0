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
        public readonly struct Select128<T> : IVTernaryOp128D<T>
            where T : unmanaged
        {
            public static Select128<T> Op => default;

            public string Moniker => moniker<N128,T>("vselect");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y, Vector128<T> z) => ginx.vselect(x,y,z);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b, T c) => gmath.select(a,b,c);
        }

        public readonly struct Select256<T> : IVTernaryOp256D<T>
            where T : unmanaged
        {
            public static Select256<T> Op => default;

            public string Moniker => moniker<N256,T>("vselect");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y, Vector256<T> z) => ginx.vselect(x,y,z);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b, T c) => gmath.select(a,b,c);
        }

    }
}