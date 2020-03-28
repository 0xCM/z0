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
    
    using static root;

    public readonly struct XnorGate<T> : IBinaryGate<T>, IBinaryGate<Vector128<T>>, IBinaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly XnorGate<T> Gate = default;

        [MethodImpl(Inline)]
        public bit Send(bit x, bit y)
            => !(x ^ y);

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gmath.not(gmath.xor(x, y));

        [MethodImpl(Inline)]
        public Vector128<T> Send(Vector128<T> x, Vector128<T> y)
            => gvec.vnot(gvec.vxor(x,y));

        [MethodImpl(Inline)]
        public Vector256<T> Send(Vector256<T> x, Vector256<T> y)
            => gvec.vnot(gvec.vxor(x,y));

    }

}