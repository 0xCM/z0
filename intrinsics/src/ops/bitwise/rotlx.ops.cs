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

    public readonly struct VrotlxOp128<T> : IVShiftOp128<T>
        where T : unmanaged
    {
        public static VrotlxOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vrotlx");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, byte offset)
            => ginx.vrotlx(x,offset);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => default;

    }

    public readonly struct VrotlxOp256<T> : IVShiftOp256<T>
        where T : unmanaged
    {
        public static VrotlxOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vrotlx");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, byte offset)
            => ginx.vrotlx(x,offset);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => default;
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vrotlx_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotlxOp128<T> vrotlx<T>(N128 w, T t = default)
            where T : unmanaged
                => VrotlxOp128<T>.Op;

        /// <summary>
        /// Operator factory for vrotlx_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotlxOp256<T> vrotlx<T>(N256 w, T t = default)
            where T : unmanaged
                => VrotlxOp256<T>.Op;
    }

}