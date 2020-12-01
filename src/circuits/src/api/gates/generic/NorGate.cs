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

    public readonly struct NorGate<T> : IBinaryGate<T>, IBinaryGate<Vector128<T>>, IBinaryGate<Vector256<T>>, IBinaryGate<Vector512<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public bit Invoke(bit x, bit y)
            => !(x | y);

        [MethodImpl(Inline)]
        public T Invoke(T x, T y)
            => gmath.not(gmath.or(x,y));

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
            => gvec.vnor(x, y);

        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
            => gvec.vnor(x, y);

        [MethodImpl(Inline)]
        public Vector512<T> Invoke(Vector512<T> x, Vector512<T> y)
            => gvec.vnor(x, y);
    }
}