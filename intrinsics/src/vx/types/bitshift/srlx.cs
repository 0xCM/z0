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
        public readonly struct Srlx128<T> : IVShiftOp128<T>, IVUnaryImm8Resolver128<T>
            where T : unmanaged
        {
            public const string Name = "vsrlx";

            public static HK.Vec128<T> hk => default;

            public static Srlx128<T> Op => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.unary<T>(hk, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => ginx.vsrlx(x,count);            
        }

        public readonly struct Srlx256<T> : IVShiftOp256<T>, IVUnaryImm8Resolver256<T>
            where T : unmanaged
        {
            public const string Name = "vsrlx";

            public static HK.Vec256<T> hk => default;

            public static Srlx256<T> Op => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.unary<T>(hk, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => ginx.vsrlx(x,count);
        }
   }
}