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
        public readonly struct LoadSpan128<T> : ISVFSpanLoad128Api<T>
            where T : unmanaged
        {
            public const string Name = "vloadspan";

            public static LoadSpan128<T> Op => default;

            static N128 w => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(ReadOnlySpan<T> x, int offset) => vgeneric.vload(n128,x,offset);            
        }

        public readonly struct LoadSpan256<T> : ISVFSpanLoad256Api<T>
            where T : unmanaged
        {
            public const string Name = "vloadspan";

            public static LoadSpan256<T> Op => default;

            static N256 w => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(ReadOnlySpan<T> x, int offset) => vgeneric.vload(n256,x,offset);
        }
    }
}