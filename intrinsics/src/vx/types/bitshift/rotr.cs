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
        public readonly struct Rotr128<T> : IVShiftOp128D<T>
            where T : unmanaged
        {
            public static Rotr128<T> Op => default;

            public const string Name = "vrotr";

            static N128 w => default;

            public Moniker Moniker => moniker<N128,T>(Name);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte imm8)
                => gApiMethod(w,Name).Reify(typeof(T)).UnaryOpImm8<T>(w,imm8);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) => ginx.vrotr(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gbits.rotr(a,offset);

        }

        public readonly struct Rotr256<T> : IVShiftOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vrotr";

            static N256 w => default;

            public static Rotr256<T> Op => default;

            public Moniker Moniker => moniker<N256,T>(Name);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte imm8)
                => gApiMethod(w,Name).Reify(typeof(T)).UnaryOpImm8<T>(w,imm8);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vrotr(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gbits.rotr(a,offset);
        }

   }

}