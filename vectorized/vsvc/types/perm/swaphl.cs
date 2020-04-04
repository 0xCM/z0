//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static root;

    partial class VSvcHosts
    {
        public readonly struct SwapHiLo128<T> : ISVUnaryOp128Api<T>
            where T : unmanaged
        {
            public const string Name = "vswaphl";

            public static SwapHiLo128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => gvec.vswaphl(x);            
        }

        public readonly struct SwapHiLo256<T> : ISVUnaryOp256Api<T>
            where T : unmanaged
        {
            public static SwapHiLo256<T> Op => default;

            public const string Name = "vswaphl";

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => gvec.vswaphl(x);
        }
    }
}