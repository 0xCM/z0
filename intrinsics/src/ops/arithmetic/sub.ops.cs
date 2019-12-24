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

    public readonly struct VsubOp128<T> : IVBinOp128<T>
        where T : unmanaged
    {
        public static VsubOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vsub");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
            => ginx.vsub(x,y);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T b)
            => gmath.sub(a,b);

    }

    public readonly struct VsubOp256<T> : IVBinOp256<T>
        where T : unmanaged
    {
        public static VsubOp256<T> Op => default;


        public string Moniker => moniker<N256,T>("vsub");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
            => ginx.vsub(x,y);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T b)
            => gmath.sub(a,b);
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vsub_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsubOp128<T> vsub<T>(N128 w, T t = default)
            where T : unmanaged
                => VsubOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsub_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsubOp256<T> vsub<T>(N256 w, T t = default)
            where T : unmanaged
                => VsubOp256<T>.Op;
    }

}