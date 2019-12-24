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

    public readonly struct VorOp128<T> : IVBinOp128<T>
        where T : unmanaged
    {
        public static VorOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vor");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
            => ginx.vor(x,y);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T b)
            => gmath.or(a,b);
    }

    public readonly struct VorOp256<T> : IVBinOp256<T>
        where T : unmanaged
    {
        public static VorOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vor");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
            => ginx.vor(x,y);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T b)
            => gmath.or(a,b);
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VorOp128<T> vor<T>(N128 w, T t = default)
            where T : unmanaged
                => VorOp128<T>.Op;

        /// <summary>
        /// Operator factory for vor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VorOp256<T> vor<T>(N256 w, T t = default)
            where T : unmanaged
                => VorOp256<T>.Op;
    }
}