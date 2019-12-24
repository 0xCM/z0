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

    public readonly struct VxorOp128<T> : IVBinOp128<T>
        where T : unmanaged
    {
        public static VxorOp128<T> Op => default;

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
            => ginx.vxor(x,y);
        
        public string Moniker => moniker<N128,T>("vxor");
    }

    public readonly struct VxorOp256<T> : IVBinOp256<T>
        where T : unmanaged
    {
        public static VxorOp256<T> Op => default;


        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
            => ginx.vxor(x,y);

        public string Moniker => moniker<N256,T>("vxor");

    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vxor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VxorOp128<T> vxor<T>(N128 w, T t = default)
            where T : unmanaged
                => VxorOp128<T>.Op;

        /// <summary>
        /// Operator factory for vxor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VxorOp256<T> vxor<T>(N256 w, T t = default)
            where T : unmanaged
                => VxorOp256<T>.Op;
    }

}