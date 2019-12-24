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

    public readonly struct VsrlOp128<T> : IVShiftOp128<T>
        where T : unmanaged
    {
        public static VsrlOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vsrl");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, byte offset)
            => ginx.vsrl(x,offset);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => gmath.srl(a,offset);
    }

    public readonly struct VsrlOp256<T> : IVShiftOp256<T>
        where T : unmanaged
    {
        public static VsrlOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vsrl");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, byte offset)
            => ginx.vsrl(x,offset);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => gmath.srl(a,offset);

    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vsrl_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlOp128<T> vsrl<T>(N128 w, T t = default)
            where T : unmanaged
                => VsrlOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsrl_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlOp256<T> vsrl<T>(N256 w, T t = default)
            where T : unmanaged
                => VsrlOp256<T>.Op;
    }
}