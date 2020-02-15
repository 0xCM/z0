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
        public readonly struct Srl128<T> : IVShiftOp128D<T>, IVUnaryImm8Resolver128<T>
            where T : unmanaged
        {
            public const string Name = "vsrl";

            public static VKT.Vec128<T> hk => default;

            public static Srl128<T> Op => default;

            public OpIdentity Id => Identity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.UnaryOpImm<T>(hk, Id, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count)
                => ginx.vsrl(x,count);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gmath.srl(a,count);
        }

        public readonly struct Srl256<T> : IVShiftOp256D<T>, IVUnaryImm8Resolver256<T>
            where T : unmanaged
        {
            public const string Name = "vsrl";

            public static VKT.Vec256<T> hk => default;

            public static Srl256<T> Op => default;

            public OpIdentity Id => Identity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.UnaryOpImm<T>(hk, Id, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => ginx.vsrl(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gmath.srl(a,count);
        }
    }
}