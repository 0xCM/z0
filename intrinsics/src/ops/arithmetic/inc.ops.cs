//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;

    public readonly struct VincOp128<T> : IVUnaryOp128<T>
        where T : unmanaged
    {
        public static VincOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vinc");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x)
            => ginx.vinc(x);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a)
            => gmath.inc(a);
    }

    public readonly struct VincOp256<T> : IVUnaryOp256<T>
        where T : unmanaged
    {
        public static VincOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vinc");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x)
            => ginx.vinc(x);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a)
            => gmath.inc(a);
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vinc_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VincOp128<T> vinc<T>(N128 w, T t = default)
            where T : unmanaged
                => VincOp128<T>.Op;

        /// <summary>
        /// Operator factory for vinc_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VincOp256<T> vinc<T>(N256 w, T t = default)
            where T : unmanaged
                => VincOp256<T>.Op;
    }

}