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
    using static Vectors;
    using static Typed;
    
    using static V0d;

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
        /// (8x16u,8x16u) -> 16x8u
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector128<ushort> x, Vector128<ushort> y, N128 w, byte t = default)
            => vpackus(x,y);

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
        /// (8x32u, 8x32u) -> 16x8u
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<uint> x0, Vector256<uint> x1, N128 w, byte t = default)  
            => vcompact(vcompact(x0, x1,n256,Konst.z16), w, t);

        /// <summary>
        /// (2x64w,2x64w) -> 4x32w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact(Vector128<ulong> x0, Vector128<ulong> x1, N128 w, uint t = default)
            => V0d.vparts(n128, (uint)V0.vcell(x0, 0),(uint)V0.vcell(x0, 1),(uint)V0.vcell(x1, 0),(uint)V0.vcell(x1, 1));

        /// <summary>
        /// (4x64w,4x64w) -> 8x32w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcompact(Vector256<ulong> x0, Vector256<ulong> x1, N256 w, uint t = default)
            => V0d.vconcat(vcompact(x0, n128,t), vcompact(x1, n128,t));

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
            => vcompact(vcompact(x0,x1,n128,Konst.z8), vcompact(x2,x3,n128,Konst.z8),w,t);

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
            => vcompact(vcompact(x0,x1,n256,Konst.z16), vcompact(x2,x3,n256,Konst.z16),w,t);

        /// <summary>
        /// 16x32u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector tuple</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(in Vector512<uint> src, N128 w, byte t = default)            
            => vcompact(src.Lo, src.Hi, w, t);

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact(Vector256<ulong> src, N128 w, uint t = default)
            => Vectors.vparts(n128, (uint)V0.vcell(src, 0),(uint)V0.vcell(src, 1),(uint)V0.vcell(src, 2),(uint)V0.vcell(src, 3));

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vcompact(Vector256<long> src, N128 w, int t = default)            
            => V0d.vpartsi(n128, (int)V0.vcell(src, 0),(int)V0.vcell(src, 1),(int)V0.vcell(src, 2),(int)V0.vcell(src, 3));

        /// <summary>
        /// 16x16i -> 16x8i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact(Vector256<short> src, N128 w, sbyte t = default)            
            => vpackss(V0d.vlo(src), V0d.vhi(src));

        /// <summary>
        /// 16x16i -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<short> src, N128 w, byte t = default)            
            => v8u(vpackss(V0d.vlo(src), V0d.vhi(src)));

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
            => vpackus(V0d.vlo(src), V0d.vhi(src));

        /// <summary>
        /// 8x16u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact(Vector128<ushort> src, N64 w, ulong t = default)            
            => V0.vcell64(vcompact(src, default, n128, Konst.z8),0);

        /// <summary>
        /// 8x32u -> 8x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcompact(Vector256<uint> src, N128 w, ushort t = default)            
            => vcompact(V0d.vlo(src),V0d.vhi(src),w,t);

        /// <summary>
        /// 8x32u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact(Vector256<uint> src, N64 w, ulong t = default)            
            => vcompact(vcompact(src, n128,Konst.z16),w,t);

        /// <summary>
        /// 8x32u -> 8x8u (a scalar vector)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<uint> src, N128 w, byte t = default)            
            => vcompact(vcompact(src, n128,Konst.z16),w,t);

        /// <summary>
        /// 8x32i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vcompact(Vector256<int> src, N128 w, short t = default)            
            => vcompact(V0d.vlo(src),V0d.vhi(src),w,t);
   }
}