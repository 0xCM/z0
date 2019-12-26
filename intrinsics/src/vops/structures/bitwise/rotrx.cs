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

    partial class VOpTypes
    {
        public readonly struct Rotrx128<T> : IVShiftOp128<T>
            where T : unmanaged
        {
            public static Rotrx128<T> Op => default;

            public string Moniker => moniker<N128,T>("vrotrx");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) => ginx.vrotrx(x,offset);
            
        }

        public readonly struct Rotrx256<T> : IVShiftOp256<T>
            where T : unmanaged
        {
            public static Rotrx256<T> Op => default;

            public string Moniker => moniker<N256,T>("vrotrx");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vrotrx(x,offset);

        }
    }
}