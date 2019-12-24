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

    public readonly struct VgtOp128<T> : IVBinOp128<T>
        where T : unmanaged
    {
        public static VgtOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vgt");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
            => ginx.vgt(x,y);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T b)
            => gmath.mul(convert<T>((uint)gmath.gt(a,b)),gmath.ones<T>());

    }

    public readonly struct VgtOp256<T> : IVBinOp256<T>
        where T : unmanaged
    {
        public static VgtOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vgt");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
            => ginx.vgt(x,y);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T b)
            => gmath.mul(convert<T>((uint)gmath.gt(a,b)), gmath.ones<T>());
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vgt_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VgtOp128<T> vgt<T>(N128 w, T t = default)
            where T : unmanaged
                => VgtOp128<T>.Op;

        /// <summary>
        /// Operator factory for vgt_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VgtOp256<T> vgt<T>(N256 w, T t = default)
            where T : unmanaged
                => VgtOp256<T>.Op;
    }
}