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

    public readonly struct VsllOp128<T> : IVShiftOp128<T>
        where T : unmanaged
    {
        public static VsllOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vsll");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, byte offset)
            => ginx.vsll(x,offset);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => gmath.sll(a,offset);

    }

    public readonly struct VsllOp256<T> : IVShiftOp256<T>
        where T : unmanaged
    {
        public static VsllOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vsll");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, byte offset)
            => ginx.vsll(x,offset);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => gmath.sll(a,offset);
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vsll_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllOp128<T> vsll<T>(N128 w, T t = default)
            where T : unmanaged
                => VsllOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsll_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllOp256<T> vsll<T>(N256 w, T t = default)
            where T : unmanaged
                => VsllOp256<T>.Op;
    }
}