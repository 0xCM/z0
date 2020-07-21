//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    partial class dvec
    {                       
        // ~ 256
        // ~ ------------------------------------------------------------------     

        /// <summary>
        /// src[i] -> lo[i], i = 1,..,15
        /// src[i] -> hi[i], i = 16,..,31
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vconvert(Vector256<sbyte> src, N512 w, short t = default)
            => z.vconvert(src, w, t);

        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vconvert(Vector256<sbyte> src, N1024 w, int t = default)
            => z.vconvert(src, w, t);

        /// <summary>
        /// 32x8u -> (16x16i, 16x16i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vconvert(Vector256<byte> src, N512 w, short t = default)
            => z.vconvert(src, w, t);

        /// <summary>
        /// 32x8u -> (8x32u, 8x32u, 8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<uint> vconvert(Vector256<byte> src, N1024 w, uint t = default)
            => z.vconvert(src, w, t);

        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert(Vector128<short> src, N512 w, long t = default)
            => z.vconvert(src, w, t);
        
        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vconvert(Vector128<ushort> src, N512 w, ulong t = default)
            => z.vconvert(src, w, t);

        /// <summary>
        /// 16x16u -> 16x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<ulong> vconvert(Vector256<ushort> src, N1024 w, ulong t = default)
            => z.vconvert(src, w, t);

        /// <summary>
        /// 16x16i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vconvert(Vector256<short> src, N512 w, int t = default)
            => z.vconvert(src, w, t);

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vconvert(Vector256<ushort> src, N512 w, uint t = default)
            => z.vconvert(src, w, t);

        /// <summary>
        /// 8x32i -> (4x64i, 4x64i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert(Vector256<int> src, N512 w, long t = default)
            => z.vconvert(src, w, t);

        /// <summary>
        /// 8x32u -> (4x64u, 4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vconvert(Vector256<uint> src, N512 w, ulong t = default)
            => z.vconvert(src, w, t);

        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert(Vector256<short> src, N512 w, long t = default)
            => z.vconvert(src, w, t);
    }
}