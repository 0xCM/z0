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
        public readonly struct Rotl128<T> : IVShiftOp128D<T>, IVUnaryImm8Resolver128<T>
            where T : unmanaged
        {
            public const string Name = "vrotl";

            public static HK.Vec128<T> hk => default;

            public static Rotl128<T> Op => default;

            public OpIdentity Moniker => Identity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => DynopImm.UnaryOp<T>(hk, Moniker, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => ginx.vrotl(x,count);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gbits.rotl(a,count);
        }

        public readonly struct Rotl256<T> : IVShiftOp256D<T>, IVUnaryImm8Resolver256<T>
            where T : unmanaged
        {
            public const string Name = "vrotl";

            public static HK.Vec256<T> hk => default;

            public static Rotl256<T> Op => default;

            public OpIdentity Moniker => Identity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => DynopImm.UnaryOp<T>(hk, Moniker, gApiMethod(hk,Name),count);
            
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => ginx.vrotl(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gbits.rotl(a,count);
        }

                
    }

}