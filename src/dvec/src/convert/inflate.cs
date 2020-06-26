// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static Konst;
    using static V0d;
    using static V0;
    using static Typed;

    partial class dvec
    {   
        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate(Vector128<byte> src, N256 w, short t = default)
            => V0d.vconvert(src, w, t);

        /// <summary>
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate(Vector128<sbyte> src, N256 w, short t = default)
            => vconcat(vmaplo(src,n128,t), vmaphi(src,n128,t));

        /// <summary>
        /// 32x8w -> 32x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vinflate(Vector256<byte> src, N512 w, short t = default)
            => vconvert(src, w,t);

        /// <summary>
        /// 32x8i -> 32x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vinflate(Vector256<sbyte> src, N512 w, short t = default)
            => vconvert(src, w, t);

        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate(Vector128<byte> src, N256 w, ushort t = default)
            => V0d.vconvert(src, w, t);

        /// <summary>
        /// 32x8u -> 32x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate(Vector256<byte> src, N512 w, ushort t = default)
            => vconvert(src, n512,t);

        /// <summary>
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vinflate(Vector128<short> src, N256 w, int t = default)
            => V0d.vconvert(src, w,t);

        /// <summary>
        /// 16x16i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vinflate(Vector256<short> src, N512 w, int t = default)
            => vconvert(src, w, t);

        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vinflate(Vector256<sbyte> src, N1024 w, int t = default)
            => vconvert(src,w,t);


        /// <summary>
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vinflate(Vector128<uint> src, N256 w, ulong t = default)        
            => vconvert(src, w, t);
        
        /// <summary>
        /// 4x32w -> 4x64w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vinflate(Vector128<int> src, N256 w, long t = default)
            => vconvert(src, w, t);
 
        /// <summary>
        /// 8x32u -> 8x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vinflate(Vector256<uint> src, N512 w, ulong t = default)
            => vconvert(src, w,t);

        /// <summary>
        /// 8x32i -> 8x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vinflate(Vector256<int> src, N512 w, long t = default)
            => vconvert(src, w,t);

        /// <summary>
        /// 32x8u -> 32x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<uint> vinflate(Vector256<byte> src, N1024 w, uint t = default)
            => vconvert(src,w,t);

        /// <summary>
        /// 16x8u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate(Vector128<byte> src, N512 w, uint t = default)
            => V0d.vconvert(src, w, t);        

        /// <summary>
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vinflate(Vector128<ushort> src, N256 w, uint t = default)
            => V0d.vconvert(src, w, t);

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate(Vector256<ushort> src, N512 w, uint t = default)
            => vconvert(src, w, t);
    }
}