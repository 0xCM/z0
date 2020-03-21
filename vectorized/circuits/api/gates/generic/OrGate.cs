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
    
    using static Root;

    public readonly struct OrGate<T> : IBinaryGate<T>,  IBinaryGate<Vector128<T>>, IBinaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly OrGate<T> Gate = default;

        [MethodImpl(Inline)]
        public bit Send(bit x, bit y)
            => x | y;

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gmath.or(x, y);

        [MethodImpl(Inline)]
        public Vector128<T> Send(Vector128<T> a, Vector128<T> b)
            => gvec.vor(a,b);

        [MethodImpl(Inline)]
        public Vector256<T> Send(Vector256<T> a, Vector256<T> b)
            => gvec.vor(a, b);
    }


}