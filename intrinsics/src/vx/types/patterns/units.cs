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
            public const string Name = "vunits";

            public static Units128<T> Op => default;

            static N128 w => default;

            public OpIdentity Id => Identity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke() => vpattern.vunits<T>(w);            
        }

        public readonly struct Units256<T> : IVPatternSource256<T>
            where T : unmanaged
        {
            public const string Name = "vunits";

            public static Units256<T> Op => default;

            static N256 w => default;
            public OpIdentity Id => Identity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke() => vpattern.vunits<T>(w);

        }
    }
}