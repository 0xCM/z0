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
        public readonly struct Srl128<T> : IVShiftOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vsrl";

            public static Srl128<T> Op => default;

            static N128 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte imm8)
                => gApiMethod(w,Name).Reify(typeof(T)).UnaryOpImm8<T>(w,imm8);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset)
                => ginx.vsrl(x,offset);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gmath.srl(a,offset);
        }

        public readonly struct Srl256<T> : IVShiftOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vsrl";

            static N256 w => default;

            public static Srl256<T> Op => default;

            public Moniker Moniker => moniker<T>(Name,w);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte imm8)
                => gApiMethod(w,Name).Reify(typeof(T)).UnaryOpImm8<T>(w,imm8);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vsrl(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gmath.srl(a,offset);
        }
    }
}