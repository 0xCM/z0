//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;

    /// <summary>
    /// Implements pop count alogirhtms that follow: 
    /// https://arxiv.org/pdf/1611.07612.pdf 
    /// https://github.com/WojciechMula/sse-popcount
    /// </summary>    
    public static class Pops
    {                
        /// <summary>
        /// Implements a carry-save adder that deposits the bitwise sum of three input vectors into two output vectors
        /// </summary>
        /// <param name="a">The first input vector</param>
        /// <param name="b">The second input vector</param>
        /// <param name="c">The third input vector</param>
        /// <param name="lo">The lo part of the result</param>
        /// <param name="hi">THe hi part of the result</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static void vcsa<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c, out Vector256<T> lo, out Vector256<T> hi)
            where T : unmanaged
        {
            var u = ginx.vxor(a,b);
            hi = ginx.vor(ginx.vand(a,b), ginx.vand(u,c));
            lo = ginx.vxor(u,c);
        }

        /// <summary>
        /// Implements a carry-save adder that deposits the bitwise sum of three input scalars into two output scalars
        /// </summary>
        /// <param name="a">The first input vector</param>
        /// <param name="b">The second input vector</param>
        /// <param name="c">The third input vector</param>
        /// <param name="lo">The lo part of the result</param>
        /// <param name="hi">THe hi part of the result</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static void csa<T>(T a, T b, T c, out T lo, out T hi)
            where T : unmanaged
        {
            var u = gmath.xor(a,b);
            hi = gmath.or(gmath.and(a,b), gmath.and(u,c));
            lo = gmath.xor(u,c);
        }
    }


}