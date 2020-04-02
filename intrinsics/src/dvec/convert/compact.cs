//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static Core;
    using static VCore;

    partial class dvec
    {   
        // ~ 16i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (8x16i,8x16i) -> 16x8i
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact(Vector128<short> x, Vector128<short> y, N128 w, sbyte t = default)
            => vpackss(x,y);

        /// <summary>
        /// (8x16i,8x16i) -> 16x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector128<short> x, Vector128<short> y, N128 w, byte t = default)
            => vpackus(x,y);

        /// <summary>
        /// (16x16i,16x16i) -> 32x8i
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vcompact(Vector256<short> x, Vector256<short> y, N256 w, sbyte t = default)            
            => vperm4x64(vpackss(x,y), Perm4L.ACBD);

        /// <summary>
        /// 16x16i -> 16x8i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact(Vector256<short> src, N128 w, sbyte t = default)            
            => vpackss(vlo(src), vhi(src));

        /// <summary>
        /// 16x16i -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<short> src, N128 w, byte t = default)            
            => v8u(vpackss(vlo(src), vhi(src)));

        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate(Vector128<byte> src, N256 w, short t = default)
            => vconvert(src, w, t);

        /// <summary>
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate(Vector128<sbyte> src, N256 w, short t = default)
            => vdirect.vconcat(vmaplo(src,n128,t), vmaphi(src,n128,t));

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

        // ~ 16u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (8x16u,8x16u) -> 16x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector128<ushort> x, Vector128<ushort> y, N128 w, byte t = default)
            => vpackus(x,y);

        /// <summary>
        /// 8x16u -> 8x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector128<ushort> x, N128 w, byte t = default)            
            => vcompact(x, default, w, t);

        /// <summary>
        /// 16x16u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<ushort> src, N128 w, byte t = default)            
            => vpackus(vlo(src), vhi(src));

        /// <summary>
        /// (16x16u,16x16u) -> 32x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcompact(Vector256<ushort> x, Vector256<ushort> y, N256 w, byte t = default)            
            => vperm4x64(vpackus(x,y), Perm4L.ACBD);

        /// <summary>
        /// 8x16u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact(Vector128<ushort> src, N64 w, ulong t = default)            
            => VCore.vcell64(vcompact(src, default, n128, z8),0);

        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate(Vector128<byte> src, N256 w, ushort t = default)
            => vconvert(src, w, t);

        /// <summary>
        /// 32x8u -> 32x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate(Vector256<byte> src, N512 w, ushort t = default)
            => vconvert(src, n512,t);

        // ~ 32i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (4x32i,4x32i) -> 8x16i
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vcompact(Vector128<int> x, Vector128<int> y, N128 w, short t = default)
            => vpackss(x,y);

        /// <summary>
        /// (8x32i,8x32i) -> 16x16i
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vcompact(Vector256<int> x, Vector256<int> y, N256 w, short t = default)            
            => vperm4x64(vpackss(x,y), Perm4L.ACBD);

        /// <summary>
        /// 8x32i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vcompact(Vector256<int> src, N128 w, short t = default)            
            => vcompact(vlo(src),vhi(src),w,t);

        /// <summary>
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vinflate(Vector128<short> src, N256 w, int t = default)
            => vconvert(src, w,t);

        /// <summary>
        /// 16x16i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vinflate(Vector256<short> src, N512 w, int t = default)
            => vconvert(src, w, t);

        // ~ 32u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (4x32u,4x32u) -> 8x16u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcompact(Vector128<uint> x, Vector128<uint> y, N128 w, ushort t = default)
            => vpackus(x,y);

        /// <summary>
        /// 8x32u -> 8x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcompact(Vector256<uint> src, N128 w, ushort t = default)            
            => vcompact(vlo(src),vhi(src),w,t);

        /// <summary>
        /// 8x32u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact(Vector256<uint> src, N64 w, ulong t = default)            
            => vcompact(vcompact(src, n128,z16),w,t);

        /// <summary>
        /// 8x32u -> 8x8u (a scalar vector)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<uint> src, N128 w, byte t = default)            
            => vcompact(vcompact(src, n128,z16),w,t);

        /// <summary>
        /// (8x32w,8x32w) -> 16x16w
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <remarks>The vpackus intrinsic emits a vector in the following form: 
        /// [0, 1, 2, 3, 8, 9, 10, 11, 4, 5, 6, 7, 12, 13, 14, 15]
        /// To make use of the result, it must be permuted to a more reasonable order, 
        /// [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vcompact(Vector256<uint> x, Vector256<uint> y, N256 w, ushort t = default)            
            => vperm4x64(vpackus(x,y), Perm4L.ACBD);

        /// <summary>
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vinflate(Vector128<ushort> src, N256 w, uint t = default)
            => vconvert(src, w, t);

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate(Vector256<ushort> src, N512 w, uint t = default)
            => vconvert(src, w, t);

        /// <summary>
        /// (4x32u,4x32u,4x32u,4x32u) -> 16x8u
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector128<uint> x0, Vector128<uint> x1, Vector128<uint> x2, Vector128<uint> x3, N128 w, byte t = default)            
            => vcompact(vcompact(x0,x1,n128,z8), vcompact(x2,x3,n128,z8),w,t);

        /// <summary>
        /// (8x32u, 8x32u) -> 16x8u
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<uint> x0, Vector256<uint> x1, N128 w, byte t = default)  
            => vcompact(vcompact(x0, x1,n256,z16), w, t);

        /// <summary>
        /// 16x32u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector tuple</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(in Vector512<uint> src, N128 w, byte t = default)            
            => vcompact(src.Lo, src.Hi, w, t);

        /// <summary>
        /// 16x8u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate(Vector128<byte> src, N512 w, uint t = default)
            => vconvert(src, w, t);        

        /// <summary>
        /// (8x32u,8x32u,8x32u,8x32u) -> 32x8w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcompact(Vector256<uint> x0, Vector256<uint> x1, Vector256<uint> x2, Vector256<uint> x3, N256 w, byte t = default) 
            => vcompact(vcompact(x0,x1,n256,z16), vcompact(x2,x3,n256,z16),w,t);

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
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vinflate(Vector256<sbyte> src, N1024 w, int t = default)
            => vconvert(src,w,t);

        /// <summary>
        /// (2x64w,2x64w) -> 4x32w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact(Vector128<ulong> x0, Vector128<ulong> x1, N128 w, uint t = default)
            => vparts(n128, (uint)vcell(x0, 0),(uint)vcell(x0, 1),(uint)vcell(x1, 0),(uint)vcell(x1, 1));

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
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact(Vector256<ulong> src, N128 w, uint t = default)
            => VCore.vparts(n128, (uint)vcell(src, 0),(uint)vcell(src, 1),(uint)vcell(src, 2),(uint)vcell(src, 3));

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vcompact(Vector256<long> src, N128 w, int t = default)            
            => VCore.vpartsi(n128, (int)vcell(src, 0),(int)vcell(src, 1),(int)vcell(src, 2),(int)vcell(src, 3));

        // ~ 8x64w <-> 8x32w
        // ~ 8:32 <-> 64
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (4x64w,4x64w) -> 8x32w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcompact(Vector256<ulong> x0, Vector256<ulong> x1, N256 w, uint t = default)
            => vdirect.vconcat(vcompact(x0, n128,t), vcompact(x1, n128,t));
            
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
    }
}