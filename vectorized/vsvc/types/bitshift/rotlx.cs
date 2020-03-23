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
        public readonly struct Rotlx128<T> : ISVShiftOp128Api<T>, IImm8V128UnaryResolver<T>
            where T : unmanaged
        {
            public const string Name = "vrotlx";

            public static VKT.Vec128<T> hk => default;

            public static Rotlx128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(hk, Id, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count)
                => gvec.vrotlx(x,count);            
        }

        public readonly struct Rotlx256<T> : ISVShiftOp256Api<T>, IImm8V256UnaryResolver<T>
            where T : unmanaged
        {
            public const string Name = "vrotlx";

            public static VKT.Vec256<T> hk => default;

            public static Rotlx256<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(hk, Id, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vrotlx(x,count);
        }
     }
}