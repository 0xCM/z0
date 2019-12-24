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

    public readonly struct VsllvOp128<T> : IVBinOp128<T>
        where T : unmanaged
    {
        public static VsllvOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vsllv");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets)
            => ginx.vsllv(x,offsets);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T offset)
            => gmath.sll(a,convert<T,byte>(offset));

    }

    public readonly struct VsllvOp256<T> : IVBinOp256<T>
        where T : unmanaged
    {
        public static VsllvOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vsllv");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offsets)
            => ginx.vsllv(x,offsets);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T offset)
            => gmath.sll(a,convert<T,byte>(offset));
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vsllv_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllvOp128<T> vsllv<T>(N128 w, T t = default)
            where T : unmanaged
                => VsllvOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsllv_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllvOp256<T> vsllv<T>(N256 w, T t = default)
            where T : unmanaged
                => VsllvOp256<T>.Op;
    }
}