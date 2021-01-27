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

    partial struct cpu
    {
        /// <summary>
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vinflate64u(Vector128<uint> src, N256 w)
            => vconvert64u(src, w);

        /// <summary>
        /// 8x32u -> 8x64u
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vinflate64u(Vector256<uint> src, N512 w)
            => vconvert64u(src, w);

        /// <summary>
        /// 8x32u -> 8x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vinflate64u(Vector256<uint> src, W512 w)
            => vconvert64u(src, w);

        /// <summary>
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vinflate64u(Vector128<uint> src, W256 w)
            => vconvert64u(src, w);
    }
}