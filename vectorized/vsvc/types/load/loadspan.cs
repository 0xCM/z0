//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Core;

    partial class VSvcHosts
    {
        public readonly struct LoadSpan128<T> : ISVFSpanLoad128Api<T>
            where T : unmanaged
        {
            public const string Name = "vloadspan";

            public static LoadSpan128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.SFunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(ReadOnlySpan<T> x, int offset) => VCore.vload(n128,x,offset);            
        }

        public readonly struct LoadSpan256<T> : ISVFSpanLoad256Api<T>
            where T : unmanaged
        {
            public const string Name = "vloadspan";

            public static LoadSpan256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.SFunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(ReadOnlySpan<T> x, int offset) => VCore.vload(n256,x,offset);
        }
    }
}