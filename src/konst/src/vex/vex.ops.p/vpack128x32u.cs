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
        public static Vector128<uint> vpack128x32u(Vector256<ulong> src)
            => vparts(w128, (uint)vcell(src, 0),(uint)vcell(src, 1),(uint)vcell(src, 2),(uint)vcell(src, 3));

        /// <summary>
        /// (2x64w,2x64w) -> 4x32w
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vpack128x32u(Vector128<ulong> a, Vector128<ulong> b)
            => vparts(w128, (uint)vcell(a, 0),(uint)vcell(a, 1),(uint)vcell(b, 0),(uint)vcell(b, 1));
    }
}