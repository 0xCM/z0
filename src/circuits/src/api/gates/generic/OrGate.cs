//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    public readonly struct OrGate<T> : IBinaryGate<T>,  IBinaryGate<Vector128<T>>, IBinaryGate<Vector256<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public Bit32 Invoke(Bit32 x, Bit32 y)
            => x | y;

        [MethodImpl(Inline)]
        public T Invoke(T x, T y)
            => gmath.or(x, y);

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> a, Vector128<T> b)
            => gvec.vor(a,b);

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> a, Vector256<T> b)
            => gvec.vor(a, b);
    }
}