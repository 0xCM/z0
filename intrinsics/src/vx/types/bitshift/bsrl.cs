//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    partial class VXTypes
    {
        public readonly struct Bsrl128<T> : IVShiftOp128<T>, IVUnaryImm8Resolver128<T>
            where T : unmanaged
        {
            public const string Name = "vbsrl";

            public static HK.Vec128<T> hk => default;

            public static Bsrl128<T> Op => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => DynopImm.UnaryOp<T>(hk, Moniker, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => ginx.vbsrl(x,count);            
        }

        public readonly struct Bsrl256<T> : IVShiftOp256<T>, IVUnaryImm8Resolver256<T>
            where T : unmanaged
        {
            public const string Name = "vbsrl";

            public static HK.Vec256<T> hk => default;

            public static Bsrl256<T> Op => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => DynopImm.UnaryOp<T>(hk, Moniker, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => ginx.vbsrl(x,count);
        }
    }
}