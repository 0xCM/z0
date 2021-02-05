//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static gmath;

    partial class gvec
    {
        /// <summary>
        /// Implements a carry-save adder that deposits the bitwise sum of three input scalars into two output scalars
        /// </summary>
        /// <param name="a">The first input vector</param>
        /// <param name="b">The second input vector</param>
        /// <param name="c">The third input vector</param>
        /// <param name="lo">The lo part of the result</param>
        /// <param name="hi">THe hi part of the result</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>See:
        /// https://arxiv.org/pdf/1611.07612.pdf
        /// https://github.com/WojciechMula/sse-popcount
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void csa<T>(T a, T b, T c, out T lo, out T hi)
            where T : unmanaged
        {
            var u = xor(a,b);
            lo = xor(u,c);
            hi = or(and(a,b), and(u,c));
        }

        /// <summary>
        /// Implements a carry-save adder that deposits the bitwise sum of three input vectors into two output vectors
        /// </summary>
        /// <param name="a">The first input vector</param>
        /// <param name="b">The second input vector</param>
        /// <param name="c">The third input vector</param>
        /// <param name="lo">The lo part of the result</param>
        /// <param name="hi">THe hi part of the result</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>See:
        /// https://arxiv.org/pdf/1611.07612.pdf
        /// https://github.com/WojciechMula/sse-popcount
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector512<T> vcsa<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
        {
            var u = vxor(a,b);
            var lo = vxor(u,c);
            var hi = gcpu.vor(gcpu.vand(a,b), gcpu.vand(u,c));
            return(lo,hi);
        }
    }
}