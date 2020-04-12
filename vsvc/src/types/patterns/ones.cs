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
        public readonly struct Ones128<T> : ISVPatternSource128Api<T>
            where T : unmanaged
        {
            public const string Name = "vones";

            public static Ones128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke() => gvec.vones<T>(VKind);            
        }

        public readonly struct Ones256<T> : ISVPatternSource256Api<T>
            where T : unmanaged
        {
            public const string Name = "vones";

            public static Ones256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke() => gvec.vones<T>(VKind);
        }
    }
}