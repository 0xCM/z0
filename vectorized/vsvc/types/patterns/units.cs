//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class VSvcHosts
    {
        public readonly struct Units128<T> : ISVPatternSource128Api<T>
            where T : unmanaged
        {
            public const string Name = "vunits";

            public static Units128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name, VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke() => Data.vunits(VKind);            
        }

        public readonly struct Units256<T> : ISVPatternSource256Api<T>
            where T : unmanaged
        {
            public const string Name = "vunits";

            public static Units256<T> Op => default;

            public Vec256Kind<T> VKind => default;
            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke() => Data.vunits<T>(VKind);

        }
    }
}