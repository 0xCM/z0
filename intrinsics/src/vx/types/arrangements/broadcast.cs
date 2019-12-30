//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public readonly struct Broadcast128<T> : IVFactoryOp128<T,T>
            where T : unmanaged
        {
            public static Broadcast128<T> Op => default;

            public const string Name = "vbroadcast";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(T a) => CpuVector.vbroadcast(n128, a);            
        }

        public readonly struct Broadcast128<S,T> : IVFactoryOp128<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            public static Broadcast128<S,T> Op => default;

            public const string Name = "vbroadcast";

            public string Moniker => moniker<N128,T>($"{Name}_{moniker<S>()}");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(S a) => CpuVector.vbroadcast(n128, convert<S,T>(a));
            
        }

        public readonly struct Broadcast256<T> : IVFactoryOp256<T,T>
            where T : unmanaged
        {
            public static Broadcast256<T> Op => default;

            public const string Name = "vbroadcast";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(T a) => CpuVector.vbroadcast(n256, a);            
        }

        public readonly struct Broadcast256<S,T> : IVFactoryOp256<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            public static Broadcast256<S,T> Op => default;

            public const string Name = "vbroadcast";

            public string Moniker => moniker<N256,T>($"{Name}_{moniker<S>()}");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(S a) => CpuVector.vbroadcast(n256, convert<S,T>(a));
            
        }
    }
}