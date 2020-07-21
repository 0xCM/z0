//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
     
    using static Typed;
    using static Konst;

    partial struct V0d
    {
        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate(Vector128<byte> src, W16 w, N1 i)
            => z.vinflate(src, w256, Zero16i);

        /// <summary>
        /// 32x8u -> 32x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate(Vector256<byte> src, W16 w)
            => z.vinflate(src, w512, Zero16u);
    }
}