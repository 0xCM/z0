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

    partial class VBits
    {
        /// <summary>
        /// Clears a sequence of bits from each component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="start">The cell-relative start index</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> bitclear<T>(Vector128<T> src, byte start, byte count)
            where T : unmanaged
        {
            var n = n128;
            var cellmask = gbits.eraser<T>(start,count);
            var vmask = Vectors.vbroadcast(n, cellmask);
            return gvec.vand(vmask,src);
        }

        /// <summary>
        /// Clears a sequence of bits from each component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="start">The cell-relative start index</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(Integers)]
        public static Vector256<T> bitclear<T>(Vector256<T> src, byte start, byte count)
            where T : unmanaged
        {
            var n = n256;
            var cellmask = gbits.eraser<T>(start,count);
            var vmask = Vectors.vbroadcast(n, cellmask);
            return gvec.vand(vmask,src);
        }
    }
}