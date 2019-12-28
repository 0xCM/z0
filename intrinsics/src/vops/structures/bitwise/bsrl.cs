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
        public readonly struct Bsrl128<T> : IVShiftOp128<T>
            where T : unmanaged
        {
            public static Bsrl128<T> Op => default;

            public const string Name = "vbsrl";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) => ginx.vbsrl(x,offset);
            
        }

        public readonly struct Bsrl256<T> : IVShiftOp256<T>
            where T : unmanaged
        {
            public static Bsrl256<T> Op => default;

            public const string Name = "vbsrl";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vbsrl(x,offset);

        }
    }
}