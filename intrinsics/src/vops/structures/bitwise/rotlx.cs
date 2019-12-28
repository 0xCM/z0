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
        public readonly struct Rotlx128<T> : IVShiftOp128<T>
            where T : unmanaged
        {
            public static Rotlx128<T> Op => default;

            public string Moniker => moniker<N128,T>("vrotlx");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset)
                => ginx.vrotlx(x,offset);
            
        }

        public readonly struct Rotlx256<T> : IVShiftOp256<T>
            where T : unmanaged
        {
            public static Rotlx256<T> Op => default;

            public string Moniker => moniker<N256,T>("vrotlx");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vrotlx(x,offset);

        }

     }

}