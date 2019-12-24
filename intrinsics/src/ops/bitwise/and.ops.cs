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

    public readonly struct VandOp128<T> : IVBinOp128<T>
        where T : unmanaged
    {
        public static VandOp128<T> Op => default;

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
            => ginx.vand(x,y);
        
        public string Moniker => moniker<N128,T>("vand");
    }

    public readonly struct VandOp256<T> : IVBinOp256<T>
        where T : unmanaged
    {
        public static VandOp256<T> Op => default;


        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
            => ginx.vand(x,y);

        public string Moniker => moniker<N256,T>("vand");

    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vand_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VandOp128<T> vand<T>(N128 w, T t = default)
            where T : unmanaged
                => VandOp128<T>.Op;

        /// <summary>
        /// Operator factory for vand_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VandOp256<T> vand<T>(N256 w, T t = default)
            where T : unmanaged
                => VandOp256<T>.Op;
    }

}