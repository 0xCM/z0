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

    public readonly struct VrotlOp128<T> : IVShiftOp128<T>
        where T : unmanaged
    {
        public static VrotlOp128<T> Op => default;

        public string Moniker => moniker<N128,T>("vrotl");

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, byte offset)
            => ginx.vrotl(x,offset);
        
        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => gbits.rotl(a,offset);

    }

    public readonly struct VrotlOp256<T> : IVShiftOp256<T>
        where T : unmanaged
    {
        public static VrotlOp256<T> Op => default;

        public string Moniker => moniker<N256,T>("vrotl");

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, byte offset)
            => ginx.vrotl(x,offset);

        [MethodImpl(Inline)]
        public T InvokeScalar(T a, byte offset)
            => gbits.rotl(a,offset);
    }

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vrotl_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotlOp128<T> vrotl<T>(N128 w, T t = default)
            where T : unmanaged
                => VrotlOp128<T>.Op;

        /// <summary>
        /// Operator factory for vrotl_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotlOp256<T> vrotl<T>(N256 w, T t = default)
            where T : unmanaged
                => VrotlOp256<T>.Op;
    }

}