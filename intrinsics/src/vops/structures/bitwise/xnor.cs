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
        public readonly struct VxnorOp128<T> : IVBinOp128<T>
            where T : unmanaged
        {
            public static VxnorOp128<T> Op => default;

            public string Moniker => moniker<N128,T>("vxnor");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
                => ginx.vxnor(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b)
                => gmath.xnor(a,b);
        }

        public readonly struct VxnorOp256<T> : IVBinOp256<T>
            where T : unmanaged
        {
            public static VxnorOp256<T> Op => default;

            public string Moniker => moniker<N256,T>("vxnor");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
                => ginx.vxnor(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b)
                => gmath.xnor(a,b);
        }

        }
}