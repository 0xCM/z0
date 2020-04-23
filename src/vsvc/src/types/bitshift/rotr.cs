//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class VSvcHosts
    {
        public readonly struct Rotr128<T> : ISVShiftOp128D<T>, ISVShiftOp128<T>, IImm8UnaryResolver128<T>
            where T : unmanaged
        {
            public const string Name = "vrotr";

            public Vec128Kind<T> VKind => default;

            public static Rotr128<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte imm8)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),imm8);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) 
                => gvec.vrotr(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) 
                => gbits.rotr(a,offset);
        }

        public readonly struct Rotr256<T> : ISVShiftOp256D<T>, ISVShiftOp256<T>, IImm8UnaryResolver256<T>
            where T : unmanaged
        {
            public const string Name = "vrotr";

            public Vec256Kind<T> VKind => default;

            public static Rotr256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vrotr(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gbits.rotr(a,count);
        }
   }
}