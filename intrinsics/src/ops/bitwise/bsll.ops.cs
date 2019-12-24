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

    public readonly struct VbsllOp128<T> : IVShiftOp128<T>
        where T : unmanaged
    {
        public static VbsllOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vbsll");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, byte offset)
            => ginx.vbsll(x,offset);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => default;
    }

    public readonly struct VbsllOp256<T> : IVShiftOp256<T>
        where T : unmanaged
    {
        public static VbsllOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vbsll");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, byte offset)
            => ginx.vbsll(x,offset);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => default;
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vbsll_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VbsllOp128<T> vbsll<T>(N128 w, T t = default)
            where T : unmanaged
                => VbsllOp128<T>.Op;

        /// <summary>
        /// Operator factory for vbsll_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VbsllOp256<T> vbsll<T>(N256 w, T t = default)
            where T : unmanaged
                => VbsllOp256<T>.Op;
    }
}