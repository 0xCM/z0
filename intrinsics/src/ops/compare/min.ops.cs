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

    public readonly struct VminOp128<T> : IVBinOp128<T>
        where T : unmanaged
    {
        public static VminOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vmin");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
            => ginx.vmin(x,y);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T b)
            => gmath.min(a,b);
    }

    public readonly struct VminOp256<T> : IVBinOp256<T>
        where T : unmanaged
    {
        public static VminOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vmin");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
            => ginx.vmin(x,y);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T b)
            => gmath.min(a,b);
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vmin_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VminOp128<T> vmin<T>(N128 w, T t = default)
            where T : unmanaged
                => VminOp128<T>.Op;

        /// <summary>
        /// Operator factory for vmin_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VminOp256<T> vmin<T>(N256 w, T t = default)
            where T : unmanaged
                => VminOp256<T>.Op;
    }
}