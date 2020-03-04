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

    partial class VXTypes
    {
        public readonly struct SwapHiLo128<T> : IVUnaryOp128<T>
            where T : unmanaged
        {
            public const string Name = "vswaphl";

            public static SwapHiLo128<T> Op => default;

            static N128 w => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => ginx.vswaphl(x);            
        }

        public readonly struct SwapHiLo256<T> : IVUnaryOp256<T>
            where T : unmanaged
        {
            public static SwapHiLo256<T> Op => default;

            public const string Name = "vswaphl";

            static N256 w => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => ginx.vswaphl(x);
        }
    }
}