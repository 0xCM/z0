//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class VXTypes
    {
        public readonly struct Broadcast128<T> : IVFactory128<T,T>
            where T : unmanaged
        {
            public const string Name = "vbroadcast";

            public static Broadcast128<T> Op => default;

            static N128 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(T a) => CpuVector.vbroadcast(n128, a);            
        }

        public readonly struct Broadcast128<S,T> : IVFactory128<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            public const string Name = "vbroadcast";

            public static Broadcast128<S,T> Op => default;

            static N128 w => default;

            public Moniker Moniker => moniker<T>($"{Name}_{primalsig<S>()}",w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(S a) => CpuVector.vbroadcast(n128, convert<S,T>(a));
            
        }

        public readonly struct Broadcast256<T> : IVFactory256<T,T>
            where T : unmanaged
        {
            public const string Name = "vbroadcast";

            public static Broadcast256<T> Op => default;

            static N256 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(T a) => CpuVector.vbroadcast(n256, a);            
        }

        public readonly struct Broadcast256<S,T> : IVFactory256<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            public const string Name = "vbroadcast";

            public static Broadcast256<S,T> Op => default;

            static N256 w => default;

            public Moniker Moniker => moniker<T>($"{Name}_{primalsig<S>()}",w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(S a) => CpuVector.vbroadcast(n256, convert<S,T>(a));
            
        }
    }
}