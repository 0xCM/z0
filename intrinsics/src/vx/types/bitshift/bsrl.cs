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
        public readonly struct Bsrl128<T> : IVShiftOp128<T>
            where T : unmanaged
        {
            public const string Name = "vbsrl";

            public static Bsrl128<T> Op => default;

            static N128 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte imm8)
                => gApiMethod(w,Name).Reify(typeof(T)).UnaryOpImm8<T>(w,imm8);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) => ginx.vbsrl(x,offset);
            
        }

        public readonly struct Bsrl256<T> : IVShiftOp256<T>
            where T : unmanaged
        {
            public static Bsrl256<T> Op => default;

            public const string Name = "vbsrl";

            static N256 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte imm8)
                => gApiMethod(w,Name).Reify(typeof(T)).UnaryOpImm8<T>(w,imm8);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vbsrl(x,offset);

        }
    }
}