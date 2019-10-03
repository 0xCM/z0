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

    public readonly struct NorGate<T> : IBinaryGate<T>, IBinaryGate<Vec128<T>>, IBinaryGate<Vec256<T>>
        where T : unmanaged
    {
        internal static readonly NorGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => !(x | y);

        [MethodImpl(Inline)]
        public T Send(in T x, in T y)
            => gmath.flip(gbits.or(in x,in y));

        [MethodImpl(Inline)]
        public Vec128<T> Send(in Vec128<T> x, in Vec128<T> y)
            => ginx.vflip(ginx.vor(in x, in y));

        [MethodImpl(Inline)]
        public Vec256<T> Send(in Vec256<T> x, in Vec256<T> y)
            => ginx.vflip(gbits.or(in x,in y));
    }
}