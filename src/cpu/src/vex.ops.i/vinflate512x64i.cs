//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Part;

    partial struct cpu
    {
        [MethodImpl(Inline), Op]
        public static Vector512<long> vinflate512x64i(Vector256<short> src)
            => (ConvertToVector256Int64(vlo(src)), ConvertToVector256Int64(vhi(src)));

        /// <summary>
        /// 8x32i -> 8x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vinflate512x64i(Vector256<int> src)
            => (vlo256x64i(src), vhi256x64i(src));
    }
}