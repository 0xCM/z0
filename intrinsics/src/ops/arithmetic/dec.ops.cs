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

    public readonly struct VdecOp128<T> : IVUnaryOp128<T>
        where T : unmanaged
    {
        public static VdecOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vdec");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x)
            => ginx.vdec(x);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a)
            => gmath.dec(a);
    }

    public readonly struct VdecOp256<T> : IVUnaryOp256<T>
        where T : unmanaged
    {
        public static VdecOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vdec");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x)
            => ginx.vdec(x);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a)
            => gmath.dec(a);
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vdec_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VdecOp128<T> vdec<T>(N128 w, T t = default)
            where T : unmanaged
                => VdecOp128<T>.Op;

        /// <summary>
        /// Operator factory for vdec_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VdecOp256<T> vdec<T>(N256 w, T t = default)
            where T : unmanaged
                => VdecOp256<T>.Op;
    }

}