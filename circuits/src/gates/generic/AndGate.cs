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

    public readonly struct AndGate<T> : IBinaryGate<T>,  IBinaryGate<Vector128<T>>, IBinaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly AndGate<T> Gate = default;

        /// <summary>
        /// Defines the canonical boolean or function, or:{0,1} x {0,1} -> {0,1}
        /// </summary>
        /// <param name="x">The first input value</param>
        /// <param name="y">The second input value</param>
        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => x & y;

        /// <summary>
        /// Simultaneously evaluates N boolean or functions wher N denotes the bit-width of the parametric type
        /// </summary>
        /// <param name="x">The left operands</param>
        /// <param name="y">The right operands</param>
        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gmath.and(x,y);

        /// <summary>
        /// Computes 128 boolean OR functions simultaneously
        /// </summary>
        /// <param name="x">The left operands</param>
        /// <param name="y">The right operands</param>
        [MethodImpl(Inline)]
        public Vector128<T> Send(Vector128<T> x, Vector128<T> y)
            => ginx.vand(x,y);

        /// <summary>
        /// Computes 256 boolean OR functions simultaneously
        /// </summary>
        /// <param name="x">The left operands</param>
        /// <param name="y">The right operands</param>
        [MethodImpl(Inline)]
        public Vector256<T> Send(Vector256<T> a, Vector256<T> b)
            => ginx.vand<T>(a,b);

    }
}