//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// 32x8u -> (16x16u, 16x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vmap16u(Vector256<byte> src, W512 w)
             => (vmaplo16u(src, w256), vmaphi16u(src, w256));

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vmap32u(Vector256<ushort> src, W512 w)
            => (vmaplo32u(src, w256), vmaphi16u(src, w256));

        /// <summary>
        /// 8x32i -> (4x64i, 4x64i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vmap64i(Vector256<int> src, W512 w)
            => (vmaplo64i(src, w256), vmaphi64i(src, w256));

        /// <summary>
        /// 8x32u -> (4x64u, 4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vmap64u(Vector256<uint> src, W512 w)
            => (vmaplo64u(src, w256), vmaphi64u(src, w256));

        [MethodImpl(Inline), Op]
        public static Vector512<long> vmap64i(Vector256<short> src, W512 w)
            => (ConvertToVector256Int64(vlo(src)), ConvertToVector256Int64(vhi(src)));

        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vmap64i(Vector128<short> src, W512 w)
            => (vmaplo64i(src, w256), vmaphi64i(src, w256));

        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vmap64u(Vector128<ushort> src, W512 w)
            => (vmaplo64u(src, w256), vmaphi64u(src, w256));

        /// <summary>
        /// 16x8i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vmap32i(Vector128<sbyte> src, W512 w)
            => (vmaplo32i(src, w256), vmaphi32i(src, w256));

        /// <summary>
        /// 16x8u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vmap32u(Vector128<byte> src, W512 w)
            => (vmaplo32u(src, w256), vmaphi32u(src, w256));
        /// <summary>
        /// 16x16u -> 16x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<ulong> vmap64u(Vector256<ushort> src, W1024 w)
            => (vmap64u(vlo(src), w512), vmap64u(vhi(src), w512));
    }
}