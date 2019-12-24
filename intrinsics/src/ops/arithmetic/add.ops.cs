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

    public readonly struct VaddOp128<T> : IVBinOp128<T>
        where T : unmanaged
    {
        public static VaddOp128<T> Op => default;

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
            => ginx.vadd(x,y);
        
        public string Moniker => moniker<N128,T>("vadd");
    }

    public readonly struct VaddOp256<T> : IVBinOp256<T>
        where T : unmanaged
    {
        public static VaddOp256<T> Op => default;


        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
            => ginx.vadd(x,y);

        public string Moniker => moniker<N256,T>("vadd");

    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vadd_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VaddOp128<T> vadd<T>(N128 w, T t = default)
            where T : unmanaged
                => VaddOp128<T>.Op;

        /// <summary>
        /// Operator factory for vadd_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VaddOp256<T> vadd<T>(N256 w, T t = default)
            where T : unmanaged
                => VaddOp256<T>.Op;
    }

}