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
        public readonly struct Sllx128<T> : IVShiftOp128<T>
            where T : unmanaged
        {
            public const string Name = "vsllx";

            static N128 w => default;

            public static Sllx128<T> Op => default;

            public Moniker Moniker => moniker<T>(Name,w);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte imm8)
                => VectorImm.unary<T>(w, gApiMethod(w,Name),imm8);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset)
                => ginx.vsllx(x,offset);            
        }

        public readonly struct Sllx256<T> : IVShiftOp256<T>
            where T : unmanaged
        {
            public const string Name = "vsllx";

            static N256 w => default;

            public static Sllx256<T> Op => default;
            
            public Moniker Moniker => moniker<T>(Name,w);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte imm8)
                => VectorImm.unary<T>(w, gApiMethod(w,Name),imm8);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vsllx(x,offset);
        }
    }
}