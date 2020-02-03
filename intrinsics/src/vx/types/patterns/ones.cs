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
        public readonly struct Ones128<T> : IVPatternSource128<T>
            where T : unmanaged
        {
            public const string Name = "vones";

            public static Ones128<T> Op => default;

            static N128 w => default;

            public OpIdentity Moniker => Identity.operation<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke() => VPattern.vones<T>(w);            
        }

        public readonly struct Ones256<T> : IVPatternSource256<T>
            where T : unmanaged
        {
            public const string Name = "vones";

            public static Ones256<T> Op => default;

            static N256 w => default;

            public OpIdentity Moniker => Identity.operation<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke() => VPattern.vones<T>(w);

        }
    }
}