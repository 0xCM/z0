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

    partial struct z
    {
        /// <summary>
        /// Rotates each component the source vector rightwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Rotrv]
        public static Vector128<uint> vrotrv(Vector128<uint> src, Vector128<uint> counts)
            => cpu.vor(vsrlv(src, counts), vsllv(src, cpu.vsub(Vector128u32, counts)));

        /// <summary>
        /// Rotates each component the source vector rightwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Rotrv]
        public static Vector128<ulong> vrotrv(Vector128<ulong> src, Vector128<ulong> counts)
            => cpu.vor(vsrlv(src, counts), vsllv(src, cpu.vsub(Vector128u64, counts)));

        /// <summary>
        /// Rotates each component the source vector rightwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Rotrv]
        public static Vector256<uint> vrotrv(Vector256<uint> src, Vector256<uint> counts)
            => cpu.vor(cpu.vsrlv(src, counts), vsllv(src, cpu.vsub(Vector256u32, counts)));

        /// <summary>
        /// Rotates each component the source vector rightwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Rotrv]
        public static Vector256<ulong> vrotrv(Vector256<ulong> src, Vector256<ulong> counts)
            => cpu.vor(cpu.vsrlv(src, counts), vsllv(src, cpu.vsub(Vector256u64, counts)));
    }
}