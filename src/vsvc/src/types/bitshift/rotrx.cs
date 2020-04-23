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
        public readonly struct Rotrx128<T> : ISVShiftOp128<T>, IImm8UnaryResolver128<T>
            where T : unmanaged
        {
            public const string Name = "vrotrx";

            public Vec128Kind<T> VKind => default;

            public static Rotrx128<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => gvec.vrotrx(x,count);            
        }

        public readonly struct Rotrx256<T> : ISVShiftOp256<T>, IImm8UnaryResolver256<T>
            where T : unmanaged
        {
            public const string Name = "vrotrx";            

            public Vec256Kind<T> VKind => default;

            public static Rotrx256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vrotrx(x,count);
        }
    }
}