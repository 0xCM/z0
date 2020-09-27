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

    public readonly struct XOrGate<T> :
        IBinaryGate<T>,
        IBinaryGate128<T>,
        IBinaryGate256<T>,
        IBinaryGate512<T>
            where T : unmanaged
    {
        [MethodImpl(Inline)]
        public Bit32 Invoke(Bit32 x, Bit32 y)
            => x ^ y;

        [MethodImpl(Inline)]
        public T Invoke(T a, T b)
            => gmath.xor(a,b);

        [MethodImpl(Inline)]
        public Vector128<T> Invoke(Vector128<T> a, Vector128<T> b)
            => gvec.vxor(a,b);

        /// <summary>
        /// Computes 256 boolean XOR functions simultaneously
        /// </summary>
        /// <param name="x">The left operands</param>
        /// <param name="y">The right operands</param>
        [MethodImpl(Inline)]
        public Vector256<T> Invoke(Vector256<T> a, Vector256<T> b)
            => gvec.vxor(a,b);

        /// <summary>
        /// Computes 512 boolean XOR functions simultaneously
        /// </summary>
        /// <param name="x">The left operands</param>
        /// <param name="y">The right operands</param>
        [MethodImpl(Inline)]
        public Vector512<T> Invoke(in Vector512<T> a, in Vector512<T> b)
            => gvec.vxor<T>(a,b);
    }
}