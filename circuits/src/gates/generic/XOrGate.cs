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

    public readonly struct XOrGate<T> : IBinaryGate<T>, IBinaryGate<Vector128<T>>, IBinaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly XOrGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => x ^ y;

        [MethodImpl(Inline)]
        public T Send(T a, T b)
            => gmath.xor(a,b);

        [MethodImpl(Inline)]
        public Vector128<T> Send(Vector128<T> a, Vector128<T> b)
            => ginx.vxor(a,b);

        [MethodImpl(Inline)]
        public Vector256<T> Send(Vector256<T> a, Vector256<T> b)
            => ginx.vxor(a,b);

    }

}