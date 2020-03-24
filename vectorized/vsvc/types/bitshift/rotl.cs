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
        public readonly struct Rotl128<T> : ISVShiftOp128DApi<T>, IImm8V128UnaryResolver<T>
            where T : unmanaged
        {
            public const string Name = "vrotl";

            public Vec128Kind<T> VKind => default;

            public static Rotl128<T> Op => default;

            public OpIdentity Id => OpIdentity.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => gvec.vrotl(x,count);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gbits.rotl(a,count);
        }

        public readonly struct Rotl256<T> : ISVShiftOp256DApi<T>, IImm8V256UnaryResolver<T>
            where T : unmanaged
        {
            public const string Name = "vrotl";

            public Vec256Kind<T> VKind => default;

            public static Rotl256<T> Op => default;

            public OpIdentity Id => OpIdentity.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);
            
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vrotl(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gbits.rotl(a,count);
        }

                
    }

}