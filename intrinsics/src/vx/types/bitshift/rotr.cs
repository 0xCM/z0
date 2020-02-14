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
        public readonly struct Rotr128<T> : IVShiftOp128D<T>, IVUnaryImm8Resolver128<T>
            where T : unmanaged
        {
            public const string Name = "vrotr";

            public static VKT.Vec128<T> hk => default;

            public static Rotr128<T> Op => default;

            public OpIdentity Moniker => Identity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte imm8)
                => Dynop.UnaryOpImm<T>(hk, Moniker, gApiMethod(hk,Name),imm8);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) 
                => ginx.vrotr(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) 
                => gbits.rotr(a,offset);
        }

        public readonly struct Rotr256<T> : IVShiftOp256D<T>, IVUnaryImm8Resolver256<T>
            where T : unmanaged
        {
            public const string Name = "vrotr";

            public static VKT.Vec256<T> hk => default;

            public static Rotr256<T> Op => default;

            public OpIdentity Moniker => Identity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.UnaryOpImm<T>(hk, Moniker, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => ginx.vrotr(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gbits.rotr(a,count);
        }
   }
}