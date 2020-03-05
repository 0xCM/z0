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
    using static Nats;

    partial class VFTypes
    {
        public readonly struct Broadcast128<T> : IVFactory128<T,T>
            where T : unmanaged
        {
            public const string Name = "vbroadcast";

            public static VKT.Vec128<T> hk => default;

            public static Broadcast128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(T a) => gvec.vbroadcast(n128, a);            
        }

        public readonly struct Broadcast128<S,T> : IVFactory128<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            public const string Name = "vbroadcast";

            public static Broadcast128<S,T> Op => default;

            static N128 w => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>($"{Name}_{TypeIdentity.numeric<S>()}",w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(S a) => gvec.vbroadcast(n128, convert<S,T>(a));            
        }

        public readonly struct Broadcast256<T> : IVFactory256<T,T>
            where T : unmanaged
        {
            public const string Name = "vbroadcast";

            public static VKT.Vec256<T> hk => default;

            public static Broadcast256<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(T a) => gvec.vbroadcast(n256, a);            
        }

        public readonly struct Broadcast256<S,T> : IVFactory256<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            public const string Name = "vbroadcast";

            public static Broadcast256<S,T> Op => default;

            static N256 w => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>($"{Name}_{TypeIdentity.numeric<S>()}",w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(S a) => gvec.vbroadcast(n256, convert<S,T>(a));            
        }
    }
}