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
        public readonly struct Reverse128<T> : ISVUnaryOp128Api<T>
            where T : unmanaged
        {
            public const string Name = "vreverse";

            public static Reverse128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => OpIdentity.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => gvec.vreverse(x);
            
        }

        public readonly struct Reverse256<T> : ISVUnaryOp256Api<T>
            where T : unmanaged
        {
            public const string Name = "vreverse";

            public static Reverse256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => OpIdentity.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => gvec.vreverse(x);
        }
    }

}