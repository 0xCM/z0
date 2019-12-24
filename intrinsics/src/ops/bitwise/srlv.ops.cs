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

    public readonly struct VsrlvOp128<T> : IVBinOp128<T>
        where T : unmanaged
    {
        public static VsrlvOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vsrlv");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets)
            => ginx.vsrlv(x,offsets);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T offset)
            => gmath.srl(a,convert<T,byte>(offset));
    }

    public readonly struct VsrlvOp256<T> : IVBinOp256<T>
        where T : unmanaged
    {
        public static VsrlvOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vsrlv");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offsets)
            => ginx.vsrlv(x,offsets);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, T offset)
            => gmath.srl(a,convert<T,byte>(offset));
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vsrlv_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlvOp128<T> vsrlv<T>(N128 w, T t = default)
            where T : unmanaged
                => VsrlvOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsrlv_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlvOp256<T> vsrlv<T>(N256 w, T t = default)
            where T : unmanaged
                => VsrlvOp256<T>.Op;
    }
}