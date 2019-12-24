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

    public readonly struct VnotOp128<T> : IVUnaryOp128<T>
        where T : unmanaged
    {
        public static VnotOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vnot");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x)
            => ginx.vnot(x);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a)
            => gmath.not(a);
    }

    public readonly struct VnotOp256<T> : IVUnaryOp256<T>
        where T : unmanaged
    {
        public static VnotOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vnot");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x)
            => ginx.vnot(x);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a)
            => gmath.not(a);
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vnot_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnotOp128<T> vnot<T>(N128 w, T t = default)
            where T : unmanaged
                => VnotOp128<T>.Op;

        /// <summary>
        /// Operator factory for vnot_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnotOp256<T> vnot<T>(N256 w, T t = default)
            where T : unmanaged
                => VnotOp256<T>.Op;
    }

}