//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    using K = Kinds;

    public readonly struct VImm8UnaryResolver128<T> :  IImm8UnaryResolver128<T>
        where T : unmanaged
    {
        OpIdentity id => default;

        public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
            => Dynop.EmbedVUnaryOpImm<T>(K.vk128<T>(), id, gApiMethod(K.vk128<T>(), id.Name),count);

        static string name(ApiKeyId k)
            => $"v{k.Format()}";

        public DynamicDelegate<UnaryOp<Vector128<T>>> inject(byte imm8, ApiKeyId kind)
            => Dynop.EmbedVUnaryOpImm<T>(K.vk128<T>(),
                ApiIdentityBuilder.build(name(kind), TypeWidth.W128, typeof(T).NumericKind(), true), gApiMethod(K.vk128<T>(), name(kind)),imm8);

        static Type ApiG => typeof(gvec);

        static MethodInfo gApiMethod(Vec128Type hk, string name)
            => ApiG.DeclaredMethods().WithName(name).OfKind(hk).Single();
    }

    public readonly struct VImm8UnaryResolver256<T> :  IImm8UnaryResolver256<T>
        where T : unmanaged
    {
        OpIdentity id => default;

        public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
            => Dynop.EmbedVUnaryOpImm<T>(K.vk256<T>(), id, gApiMethod(K.vk256<T>(), id.Name),count);

        static Type ApiG => typeof(gvec);

        static MethodInfo gApiMethod(Vec256Type hk, string name)
            => ApiG.DeclaredMethods().WithName(name).OfKind(hk).Single();
    }
}