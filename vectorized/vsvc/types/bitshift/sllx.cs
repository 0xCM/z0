//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static root;

    partial class VSvcHosts
    {
        public readonly struct Sllx128<T> : ISVShiftOp128Api<T>
            where T : unmanaged
        {
            public const string Name = "vsllx";

            public Vec128Kind<T> VKind => default;

            public static Sllx128<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count)
                => gvec.vsllx(x,count);            
        }

        public readonly struct Sllx256<T> : ISVShiftOp256Api<T>
            where T : unmanaged
        {
            public const string Name = "vsllx";

            public Vec256Kind<T> VKind => default;

            public static Sllx256<T> Op => default;
            
            public OpIdentity Id => Identify.SFunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vsllx(x,count);
        }
    }
}