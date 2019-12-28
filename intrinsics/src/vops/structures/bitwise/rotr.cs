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

    partial class VXTypes
    {
        public readonly struct Rotr128<T> : IVShiftOp128D<T>
            where T : unmanaged
        {
            public static Rotr128<T> Op => default;

            public string Moniker => moniker<N128,T>("vrotr");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) => ginx.vrotr(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gbits.rotr(a,offset);

        }

        public readonly struct Rotr256<T> : IVShiftOp256D<T>
            where T : unmanaged
        {
            public static Rotr256<T> Op => default;

            public string Moniker => moniker<N256,T>("vrotr");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vrotr(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gbits.rotr(a,offset);
        }

   }

}