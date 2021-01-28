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

    using K = VK;

    public readonly struct VImm8UnaryResolvers
    {
        public static VImm8UnaryResolver128<T> create<T>(Type host, W128 w)
            where T : unmanaged
                => new VImm8UnaryResolver128<T>(host);

        public static VImm8UnaryResolver256<T> create<T>(Type host, W256 w)
            where T : unmanaged
                => new VImm8UnaryResolver256<T>(host);
    }

    public readonly struct VImm8UnaryResolver128<T> : IImm8UnaryResolver128<T>
        where T : unmanaged
    {
        OpIdentity id => default;

        public Type Host {get;}


        public VImm8UnaryResolver128(Type host)
        {
            Host = host;
        }

        public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
            => Dynop.EmbedVUnaryOpImm<T>(K.vk128<T>(), id, gApiMethod(K.vk128<T>(), id.Name),count);

        static string name(ApiClass k)
            => $"v{k.Format()}";

        public DynamicDelegate<UnaryOp<Vector128<T>>> inject(byte imm8, ApiClass kind)
            => Dynop.EmbedVUnaryOpImm<T>(K.vk128<T>(),
                ApiIdentify.build(name(kind), TypeWidth.W128, typeof(T).NumericKind(), true), gApiMethod(K.vk128<T>(), name(kind)),imm8);


        MethodInfo gApiMethod(Vec128Type hk, string name)
            => Host.DeclaredMethods().WithName(name).OfKind(hk).Single();
    }

    public readonly struct VImm8UnaryResolver256<T> :  IImm8UnaryResolver256<T>
        where T : unmanaged
    {
        public Type Host {get;}

        public VImm8UnaryResolver256(Type host)
        {
            Host = host;
        }

        OpIdentity id => default;

        public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
            => Dynop.EmbedVUnaryOpImm<T>(K.vk256<T>(), id, gApiMethod(K.vk256<T>(), id.Name),count);


        MethodInfo gApiMethod(Vec256Type hk, string name)
            => Host.DeclaredMethods().WithName(name).OfKind(hk).Single();
    }
}