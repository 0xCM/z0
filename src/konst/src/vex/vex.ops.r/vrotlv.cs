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

    partial struct z
    {
        /// <summary>
        /// Rotates each component the source vector leftwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Rotlv]
        public static Vector128<uint> vrotlv(Vector128<uint> src, Vector128<uint> counts)
            => cpu.vor(vsllv(src, counts), vsrlv(src, cpu.vsub(Vector128u32, counts)));

        /// <summary>
        /// Rotates each component the source vector leftwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Rotlv]
        public static Vector128<ulong> vrotlv(Vector128<ulong> src, Vector128<ulong> counts)
            => cpu.vor(vsllv(src,counts),vsrlv(src, cpu.vsub(Vector128u64,counts)));

        /// <summary>
        /// Rotates each component the source vector leftwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Rotlv]
        public static Vector256<uint> vrotlv(Vector256<uint> src, Vector256<uint> counts)
            => cpu.vor(vsllv(src,counts), cpu.vsrlv(src, cpu.vsub(Vector256u32,counts)));

        /// <summary>
        /// Rotates each component the source vector leftwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Rotlv]
        public static Vector256<ulong> vrotlv(Vector256<ulong> src, Vector256<ulong> counts)
            => cpu.vor(vsllv(src,counts), cpu.vsrlv(src,  cpu.vsub(Vector256u64,counts)));
    }
}