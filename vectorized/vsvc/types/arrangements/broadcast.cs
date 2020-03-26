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

    partial class VSvcHosts
    {
        public readonly struct Broadcast128<T> : ISVFactory128Api<T,T>
            where T : unmanaged
        {
            public const string Name = "vbroadcast";

            public Vec128Kind<T> VKind => default;

            public static Broadcast128<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(T a) => vgeneric.vbroadcast(n128, a);            
        }

        public readonly struct Broadcast128<S,T> : ISVFactory128Api<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            public const string Name = "vbroadcast";

            public static Broadcast128<S,T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.SFunc<T>($"{Name}_{Identify.NumericType<S>()}", VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(S a) => vgeneric.vbroadcast(n128, convert<S,T>(a));            
        }

        public readonly struct Broadcast256<T> : ISVFactory256Api<T,T>
            where T : unmanaged
        {
            public const string Name = "vbroadcast";

            public Vec256Kind<T> VKind => default;

            public static Broadcast256<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(T a) => vgeneric.vbroadcast(n256, a);            
        }

        public readonly struct Broadcast256<S,T> : ISVFactory256Api<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            public const string Name = "vbroadcast";

            public static Broadcast256<S,T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.SFunc<T>($"{Name}_{Identify.NumericType<S>()}", VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(S a) => vgeneric.vbroadcast(n256, convert<S,T>(a));            
        }
    }
}