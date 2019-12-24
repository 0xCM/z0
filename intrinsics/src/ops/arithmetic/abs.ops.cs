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

    public readonly struct VabsOp128<T> : IVUnaryOp128<T>
        where T : unmanaged
    {
        public static VabsOp128<T> Op => default;

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x)
            => ginx.vabs(x);
        
        public string Moniker => moniker<N128,T>("vabs");
    }

    public readonly struct VabsOp256<T> : IVUnaryOp256<T>
        where T : unmanaged
    {
        public static VabsOp256<T> Op => default;


        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x)
            => ginx.vabs(x);

        public string Moniker => moniker<N256,T>("vabs");

    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vabs_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VabsOp128<T> vabs<T>(N128 w, T t = default)
            where T : unmanaged
                => VabsOp128<T>.Op;

        /// <summary>
        /// Operator factory for vabs_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VabsOp256<T> vabs<T>(N256 w, T t = default)
            where T : unmanaged
                => VabsOp256<T>.Op;
    }

}