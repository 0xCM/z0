//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;

    partial class VServices
    {
        public readonly struct SwapHiLo128<T> : IUnaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x)
                => gcpu.vswaphl(x);
        }

        public readonly struct SwapHiLo256<T> : IUnaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => gcpu.vswaphl(x);
        }
    }
}