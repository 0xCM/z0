//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class gbits
    {
        /// <summary>
        /// Clears a sequence of bits from each component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="start">The cell-relative start index</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vclear<T>(Vector128<T> src, byte start, int count)
            where T : unmanaged
        {
            var n = n128;
            var cellmask = gbits.eraser<T>(start,count);
            var vmask = CpuVector.broadcast(n, cellmask);
            return ginx.vand(vmask,src);
        }

        /// <summary>
        /// Clears a sequence of bits from each component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="start">The cell-relative start index</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vclear<T>(Vector256<T> src, byte start, int count)
            where T : unmanaged
        {
            var n = n256;
            var cellmask = gbits.eraser<T>(start,count);
            var vmask = CpuVector.broadcast(n, cellmask);
            return ginx.vand(vmask,src);
        }
    }
}