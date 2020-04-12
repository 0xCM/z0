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

    using static Seed;
    using static Memories;

    public readonly struct MuxGate<T> : ITernaryGate<T>,  ITernaryGate<Vector128<T>>, ITernaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly MuxGate<T> Gate = default;

        [MethodImpl(Inline)]
        public bit Send(bit a, bit b, bit c)
            => a ? b : c;

        [MethodImpl(Inline)]
        public T Send(T a, T b, T c)
            => gmath.select(a,b,c);

        [MethodImpl(Inline)]
        public Vector128<T> Send(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            => gvec.vselect(x,y,z);

        [MethodImpl(Inline)]
        public Vector256<T> Send(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            => gvec.vselect(x,y,z);

    }
}