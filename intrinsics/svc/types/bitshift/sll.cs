//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class VFTypes
    {
        public readonly struct Sll128<T> : IVShiftOp128D<T>, IImm8V128UnaryResolver<T>
            where T : unmanaged
        {
            public const string Name = "vsll";

            public static VKT.Vec128<T> hk => default;

            public static Sll128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.ImmVUnaryOP<T>(hk, Id, gApiMethod(hk,Name),count);
            
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => ginx.vsll(x,count);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gmath.sll(a,count);

        }

        public readonly struct Sll256<T> : IVShiftOp256D<T>, IImm8V256UnaryResolver<T>
            where T : unmanaged
        {
            public const string Name = "vsll";            

            public static VKT.Vec256<T> hk => default;

            public static Sll256<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.ImmVUnaryOp<T>(hk, Id, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => ginx.vsll(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gmath.sll(a,count);
        }
    }
}