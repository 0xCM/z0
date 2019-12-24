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

    public readonly struct VtestcOp128<T> : IVBinaryPred128<T>
        where T : unmanaged
    {
        public static VtestcOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vtestc");

        [MethodImpl(Inline)]
        public bit Invoke(Vector128<T> x,Vector128<T> y)
            => ginx.vtestc(x,y);

        [MethodImpl(Inline)]
        public bit InvokeScalar(T a, T b)
            => default;
    }

    public readonly struct VtestcOp256<T> : IVBinaryPred256<T>
        where T : unmanaged
    {
        public static VtestcOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vtestc");

        [MethodImpl(Inline)]
        public bit Invoke(Vector256<T> x,Vector256<T> y)
            => ginx.vtestc(x,y);

        [MethodImpl(Inline)]
        public bit InvokeScalar(T a, T b)
            => default;
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vtestc_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VtestcOp128<T> vtestc<T>(N128 w, T t = default)
            where T : unmanaged
                => VtestcOp128<T>.Op;

        /// <summary>
        /// Operator factory for vtestc_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VtestcOp256<T> vtestc<T>(N256 w, T t = default)
            where T : unmanaged
                => VtestcOp256<T>.Op;
    }
}