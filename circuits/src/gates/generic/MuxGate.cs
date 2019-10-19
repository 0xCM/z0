//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct MuxGate<T> : ITernaryGate<T>,  ITernaryGate<Vector128<T>>, ITernaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly MuxGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y, Bit control)
            => control ? y : x;

        [MethodImpl(Inline)]
        public T Send(T x, T y, T control)
            => gmath.or(gmath.andnot(control, x), gmath.and(y, control));

        [MethodImpl(Inline)]
        public Vector128<T> Send(Vector128<T> x, Vector128<T> y, Vector128<T> control)
            => ginx.vor(ginx.vandnot(control,x), ginx.vand(y, control));

        [MethodImpl(Inline)]
        public Vector256<T> Send(Vector256<T> x, Vector256<T> y, Vector256<T> control)
            => ginx.vor(ginx.vandnot(control,x), ginx.vand<T>(y, control));

    }
}