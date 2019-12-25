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

    public readonly struct VtestzOp128<T> : IVBinaryPred128<T>
        where T : unmanaged
    {
        public static VtestzOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vtestz");

        [MethodImpl(Inline)]
        public bit Invoke(Vector128<T> x,Vector128<T> y)
            => ginx.vtestz(x,y);

        [MethodImpl(Inline)]
        public bit InvokeScalar(T a, T b)
            => default;
    }

    public readonly struct VtestzOp256<T> : IVBinaryPred256<T>
        where T : unmanaged
    {
        public static VtestzOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vtestz");

        [MethodImpl(Inline)]
        public bit Invoke(Vector256<T> x,Vector256<T> y)
            => ginx.vtestz(x,y);

        [MethodImpl(Inline)]
        public bit InvokeScalar(T a, T b)
            => default;
    }

    partial class VOps
    {
   }
}