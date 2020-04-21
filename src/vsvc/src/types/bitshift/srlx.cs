//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed; using static Memories;

    partial class VSvcHosts
    {
        public readonly struct Srlx128<T> : ISVShiftOp128Api<T>, ISVImm8UnaryResolver128Api<T>
            where T : unmanaged
        {
            public const string Name = "vsrlx";

            public Vec128Kind<T> VKind => default;

            public static Srlx128<T> Op => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => gvec.vsrlx(x,count);            
        }

        public readonly struct Srlx256<T> : ISVShiftOp256Api<T>, ISVImm8UnaryResolver256Api<T>
            where T : unmanaged
        {
            public const string Name = "vsrlx";

            public Vec256Kind<T> VKind => default;

            public static Srlx256<T> Op => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vsrlx(x,count);
        }
   }
}