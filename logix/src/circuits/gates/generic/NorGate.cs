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

    public readonly struct NorGate<T> : IBinaryGate<T>, IBinaryGate<Vector128<T>>, IBinaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly NorGate<T> Gate = default;

        [MethodImpl(Inline)]
        public bit Send(bit x, bit y)
            => !(x | y);

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gmath.not(gmath.or(x,y));

        [MethodImpl(Inline)]
        public Vector128<T> Send(Vector128<T> x, Vector128<T> y)
            => ginx.vnot(ginx.vor(x, y));

        [MethodImpl(Inline)]
        public Vector256<T> Send(Vector256<T> x, Vector256<T> y)
            => ginx.vnot(ginx.vor(x,y));
    }
}