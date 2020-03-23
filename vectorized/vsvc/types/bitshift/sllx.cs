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

    partial class VSvcHosts
    {
        public readonly struct Sllx128<T> : ISVShiftOp128Api<T>
            where T : unmanaged
        {
            public const string Name = "vsllx";

            public static VKT.Vec128<T> hk => default;

            public static Sllx128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(hk, Id, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count)
                => gvec.vsllx(x,count);            
        }

        public readonly struct Sllx256<T> : ISVShiftOp256Api<T>
            where T : unmanaged
        {
            public const string Name = "vsllx";

            public static VKT.Vec256<T> hk => default;

            public static Sllx256<T> Op => default;
            
            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(hk, Id, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vsllx(x,count);
        }
    }
}