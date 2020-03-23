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
        public readonly struct Units128<T> : ISVPatternSource128Api<T>
            where T : unmanaged
        {
            public const string Name = "vunits";

            public static Units128<T> Op => default;

            static N128 w => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke() => Data.vunits<T>(w);            
        }

        public readonly struct Units256<T> : ISVPatternSource256Api<T>
            where T : unmanaged
        {
            public const string Name = "vunits";

            public static Units256<T> Op => default;

            static N256 w => default;
            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke() => Data.vunits<T>(w);

        }
    }
}