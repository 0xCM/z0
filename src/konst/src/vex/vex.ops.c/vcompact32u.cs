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
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact32u(Vector256<ulong> src)
            => vparts(w128, (uint)vcell(src, 0),(uint)vcell(src, 1),(uint)vcell(src, 2),(uint)vcell(src, 3));

        /// <summary>
        /// (2x64w,2x64w) -> 4x32w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact32u(Vector128<ulong> x0, Vector128<ulong> x1, W128 w)
            => cpu.vparts(w128, (uint)vcell(x0, 0),(uint)vcell(x0, 1),(uint)vcell(x1, 0),(uint)vcell(x1, 1));

        /// <summary>
        /// (4x64w,4x64w) -> 8x32w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcompact32u(Vector256<ulong> x0, Vector256<ulong> x1, N256 w)
            => cpu.vconcat(vcompact32u(x0, w128), vcompact32u(x1, w128));

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact32u(Vector256<ulong> src, W128 w)
            => cpu.vparts(w128, (uint)vcell(src, 0),(uint)vcell(src, 1),(uint)vcell(src, 2),(uint)vcell(src, 3));


    }
}