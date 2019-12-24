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

    public readonly struct VsllxOp128<T> : IVShiftOp128<T>
        where T : unmanaged
    {
        public static VsllxOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vsllx");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, byte offset)
            => ginx.vsllx(x,offset);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => default;
    }

    public readonly struct VsllxOp256<T> : IVShiftOp256<T>
        where T : unmanaged
    {
        public static VsllxOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vsllx");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, byte offset)
            => ginx.vsllx(x,offset);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => default;

    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vsllx_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllxOp128<T> vsllx<T>(N128 w, T t = default)
            where T : unmanaged
                => VsllxOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsllx_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllxOp256<T> vsllx<T>(N256 w, T t = default)
            where T : unmanaged
                => VsllxOp256<T>.Op;
    }
}