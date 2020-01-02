//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public readonly struct Srlx128<T> : IVShiftOp128<T>
            where T : unmanaged
        {
            public static Srlx128<T> Op => default;

            public string Moniker => moniker<N128,T>("vsrlx");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) => ginx.vsrlx(x,offset);
            
        }

        public readonly struct Srlx256<T> : IVShiftOp256<T>
            where T : unmanaged
        {
            public static Srlx256<T> Op => default;

            public string Moniker => moniker<N256,T>("vsrlx");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vsrlx(x,offset);

        }
   }
}