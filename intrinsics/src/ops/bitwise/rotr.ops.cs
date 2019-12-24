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

    public readonly struct VrotrOp128<T> : IVShiftOp128<T>
        where T : unmanaged
    {
        public static VrotrOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vrotr");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, byte offset)
            => ginx.vrotr(x,offset);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => gbits.rotr(a,offset);

    }

    public readonly struct VrotrOp256<T> : IVShiftOp256<T>
        where T : unmanaged
    {
        public static VrotrOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vrotr");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, byte offset)
            => ginx.vrotr(x,offset);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => gbits.rotr(a,offset);
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vrotr_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotrOp128<T> vrotr<T>(N128 w, T t = default)
            where T : unmanaged
                => VrotrOp128<T>.Op;

        /// <summary>
        /// Operator factory for vrotr_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotrOp256<T> vrotr<T>(N256 w, T t = default)
            where T : unmanaged
                => VrotrOp256<T>.Op;
    }

}