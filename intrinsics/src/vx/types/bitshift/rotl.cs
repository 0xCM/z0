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

            public static Rotl128<T> Op => default;

            static N128 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte imm8)
                => VectorImm.unary<T>(w, gApiMethod(w,Name),imm8);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) => ginx.vrotl(x,offset);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gbits.rotl(a,offset);

        }

        public readonly struct Rotl256<T> : IVShiftOp256D<T>, IVUnaryImm8Resolver256<T>
            where T : unmanaged
        {
            public const string Name = "vrotl";

            static N256 w => default;

            public static Rotl256<T> Op => default;

            public Moniker Moniker => moniker<T>(Name,w);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte imm8)
                => VectorImm.unary<T>(w, gApiMethod(w,Name),imm8);
            
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vrotl(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gbits.rotl(a,offset);
        }

                
    }

}