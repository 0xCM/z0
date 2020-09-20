//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class gvec
    {
        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vblendbits<T>(Vector128<T> x, Vector128<T> y, Vector128<T> mask)
            where T : unmanaged
                => gvec.vxor(x, gvec.vand(gvec.vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vblendbits<T>(Vector256<T> x, Vector256<T> y, Vector256<T> mask)
            where T : unmanaged
                => gvec.vxor(x, gvec.vand(gvec.vxor(x,y), mask));

        /// <summary>
        /// Clears a sequence of bits from each component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="start">The cell-relative start index</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vbitclear<T>(Vector128<T> src, byte start, byte count)
            where T : unmanaged
        {
            var n = n128;
            var cellmask = gbits.eraser<T>(start,count);
            var vmask = z.vbroadcast(n, cellmask);
            return vand(vmask,src);
        }

        /// <summary>
        /// Clears a sequence of bits from each component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="start">The cell-relative start index</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(Integers)]
        public static Vector256<T> vbitclear<T>(Vector256<T> src, byte start, byte count)
            where T : unmanaged
        {
            var n = n256;
            var cellmask = gbits.eraser<T>(start,count);
            var vmask = z.vbroadcast(n, cellmask);
            return vand(vmask,src);
        }
    }
}