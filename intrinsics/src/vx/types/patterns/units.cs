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
        public readonly struct Units128<T> : IVPatternSource128<T>
            where T : unmanaged
        {
            public static Units128<T> Op => default;

            public const string Name = "vunits";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke() => VPattern.vunits<T>(n128);            
        }

        public readonly struct Units256<T> : IVPatternSource256<T>
            where T : unmanaged
        {
            public static Units256<T> Op => default;

            public const string Name = "vunits";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke() => VPattern.vunits<T>(n256);

        }
    }
}