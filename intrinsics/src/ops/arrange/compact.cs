//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class dinx
    {   

        // ~ 16x16w <-> 16x8w
        // ~ 16:8 <-> 16
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (8x16w,8x16w) -> 16x8w
        /// Compacts 16 16-bit integers to 16 8-bit integers
        /// 16:16 -> 8
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector128<ushort> x, Vector128<ushort> y)
            => vpackus(x,y);

        /// <summary>
        /// (8x16w,8x16w) -> 16x8w
        /// Compacts 16 16-bit integers to 16 8-bit integers
        /// 16:16 -> 8
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector128<ushort> x, Vector128<ushort> y, out Vector128<byte> dst)
            => dst = vcompact(x,y);

        /// <summary>
        /// 16x8w -> (8x16w, 8x16w)
        /// 16:8 -> 16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vinflate(Vector128<byte> x, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {            
            vconvert(x, out lo);
            vconvert(vhi(x), out hi);
        }

        // ~ 32x16w <-> 32x8w
        // ~ 32:8 <-> 16
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (16x16w,16x16w) -> 32x8w
        /// Compacts 32 16-bit integers to 32 8-bit integers
        /// 32:16 -> 8
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vcompact(Vector256<ushort> x, Vector256<ushort> y)            
            => vperm4x64(vpackus(x,y), Perm4.ACBD);

        /// <summary>
        /// (16x16w,16x16w) -> 32x8w
        /// Compacts 32 16-bit integers to 32 8-bit integers
        /// 32:16 -> 8
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vcompact(Vector256<ushort> x, Vector256<ushort> y, out Vector256<byte> dst)            
            => dst = vcompact(x,y);

        /// <summary>
        /// 32x8w -> (16x16w,16x16w)
        /// 32:8 -> 16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vinflate(Vector256<byte> src, out Vector256<ushort> x0, out Vector256<ushort> x1)
            => vconvert(src, out x0, out x1);

        // ~ 16x16w <-> 16x8w
        // ~ 16:8 <-> 16
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// 16x16w -> 16x8w
        /// Compacts 16 16-bit integers to 16 8-bit integers
        /// 16:16 -> 8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector256<ushort> src, out Vector128<byte> dst)            
            => dst = vcompact(vlo(src),vhi(src));

        /// <summary>
        /// 16x8w -> 16x16w
        /// 16:8 -> 16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vinflate(Vector128<byte> src, out Vector256<ushort> dst)
            => vconvert(src, out dst);

        // ~ 8x16w <-> 8x32w
        // ~ 8:16 <-> 32
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (4x32w,4x32w) -> 8x16w
        /// Compacts 8 32-bit integers to 8 16-bit integers
        /// 8:32 -> 16
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vcompact(Vector128<uint> x, Vector128<uint> y)
            => vpackus(x,y);

        /// <summary>
        /// 8x16w -> (4x32w,4x32w)
        /// 8:16 -> 32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vinflate(Vector128<ushort> src, out Vector128<uint> x0, out Vector128<uint> x1)
        {
            vconvert(src, out Vector256<uint> dst);
            x0 = vlo(dst);
            x1 = vhi(dst);
        }

        // ~ 8x32w <-> 8x16w
        // ~ 8:16 <-> 32
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// 8x32w -> 8x16w
        /// Compacts 8 32-bit integers to 8 16-bit integers
        /// 8:32 -> 16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vcompact(Vector256<uint> x, out Vector128<ushort> dst)            
            => dst = vcompact(vlo(x),vhi(x));

        /// <summary>
        /// (4x32w,4x32w) -> 8x16w
        /// Compacts 8 32-bit integers to 8 16-bit integers
        /// 8:32 -> 16
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vcompact(Vector128<uint> x, Vector128<uint> y, out Vector128<ushort> dst)
            => dst = vcompact(x,y);

        /// <summary>
        /// 8x16w -> 8x32w
        /// Expands 8 16-bit integers to 8 32-bit integers
        /// 8:16 -> 32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vinflate(Vector128<ushort> src, out Vector256<uint> dst)
            => vconvert(src, out dst);


        // ~ 16x32w <-> 16x16w
        // ~ 16x16 <-> 32
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (8x32w,8x32w) -> 16x16w
        /// Compacts 16 32-bit integers to 16 16-bit integers
        /// 16:32 -> 16
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <remarks>The vpackus intrinsic emits a vector in the following form: 
        /// [0, 1, 2, 3, 8, 9, 10, 11, 4, 5, 6, 7, 12, 13, 14, 15]
        /// To make use of the result, int must be permuted to a more reasonable order that follows
        /// [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
        /// </remarks>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vcompact(Vector256<uint> x, Vector256<uint> y)            
            => vperm4x64(vpackus(x,y), Perm4.ACBD);


        /// <summary>
        /// (8x32w,8x32w) -> 16x16w
        /// Compacts 16 32-bit integers to 16 16-bit integers
        /// 16:32 -> 16
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vcompact(Vector256<uint> x, Vector256<uint> y, out Vector256<ushort> dst)            
            => dst = vcompact(x,y);            

        /// <summary>
        /// 16x16w -> (8x32w, 8x32w)
        /// Expands 16 16-bit integers to 16 32-bit integers
        /// 16:16 -> 32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vinflate(Vector256<ushort> src, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            vconvert(vlo(src), out lo);
            vconvert(vhi(src), out hi);
        }


        // ~ 16x32w <-> 16x8w
        // ~ 16:8 <-> 32
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (4x32w,4x32w,4x32w,4x32w) -> 16x8w
        /// Compacts 16 32-bit integers to 16 8-bit integers
        /// 16:32 -> 8
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector128<uint> x0, Vector128<uint> x1, Vector128<uint> x2, Vector128<uint> x3, out Vector128<byte> dst)            
            => vcompact(vcompact(x0,x1), vcompact(x2,x3),out dst);

        /// <summary>
        /// 16x8x -> (4x32w, 4x32w, 4x32w, 4x32w)
        /// 16:8 -> 32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        /// <param name="x2">The third target vector</param>
        /// <param name="x3">The fourth target vector</param>
        [MethodImpl(Inline)]
        public static void vinflate(Vector128<byte> src, out Vector128<uint> x0, out Vector128<uint> x1, out Vector128<uint> x2, out Vector128<uint> x3)            
        {
            vconvert(src, out x0);
            vconvert(vsrlx(src,32*1), out x1);
            vconvert(vsrlx(src,32*2), out x2);
            vconvert(vsrlx(src,32*3), out x3);
        }

        /// <summary>
        /// (8x32w, 8x32w) -> 16x8w
        /// Compacts 16 32-bit integers to 16 8-bit integers
        /// 16:32 -> 8
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector256<uint> x0, Vector256<uint> x1, out Vector128<byte> dst)            
            => vcompact(vcompact(x0,x1, out Vector256<ushort> _), out dst);

        /// <summary>
        /// 16x8w -> (8x32w,8x32w)
        /// 16:8 -> 32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vinflate(Vector128<byte> src, out Vector256<uint> x0, out Vector256<uint> x1)
        {            
            vconvert(src, out x0);
            vconvert(vsrlx(src,64), out x1);
        }

        // ~ 32x32w <-> 32x8w
        // ~ 32:8 <-> 32
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (8x32w,8x32w,8x32w,8x32w) -> 32x8w
        /// Compacts 32 32-bit integers to 32 8-bit integers
        /// 32:32 -> 8
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vcompact(Vector256<uint> x0, Vector256<uint> x1, Vector256<uint> x2, Vector256<uint> x3, out Vector256<byte> dst)            
            => vcompact(vcompact(x0,x1), vcompact(x2,x3),out dst);

        /// <summary>
        /// 32x8w -> (8x32w, 8x32w, 8x32w, 8x32w)
        /// 32:8 -> 32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector that receives the first 64-bit segment from the source vector </param>
        /// <param name="x1">The second target vector that receives the second 64-bit segment from the source vector</param>
        /// <param name="x2">The third targetvector that receives the third 64-bit segment from the source vector</param>
        /// <param name="x3">The fourth target vector that receives the fourth 64-bit segment from the source vector</param>
        [MethodImpl(Inline)]
        public static void vinflate(Vector256<byte> src, out Vector256<uint> x0, out Vector256<uint> x1, out Vector256<uint> x2, out Vector256<uint> x3)
        {
            vconvert(src, out Vector256<ushort> lo, out Vector256<ushort> hi);
            vconvert(lo, out x0, out x1);
            vconvert(hi, out x2, out x3);
        }

        // ~ 4x64w <-> 4x32w
        // ~ 4:32 <-> 64
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (2x64w,2x64w) -> 4x32w
        /// Compacts 4 64-bit integers to 4 32-bit integers
        /// 4:64 -> 32
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vcompact(Vector128<ulong> x0, Vector128<ulong> x1, out Vector128<uint> dst)
            => dst = vparts(n128, (uint)vcell(x0, 0),(uint)vcell(x0, 1),(uint)vcell(x1, 0),(uint)vcell(x1, 1));

        /// <summary>
        /// 4x32w -> (2x64w, 2x64w)
        /// 4:32 -> 64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vinflate(Vector128<uint> src, out Vector128<ulong> x0, out Vector128<ulong> x1)
        {
            vinflate(src, out var dst);
            x0 = vlo(dst);
            x1 = vhi(dst);
        }

        /// <summary>
        /// 4x64w -> 4x32w
        /// Compacts 4 64-bit integers to 4 32-bit integers
        /// 4:64 -> 32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vcompact(Vector256<ulong> src, out Vector128<uint> dst)
            => dst = vparts(n128, (uint)vcell(src, 0),(uint)vcell(src, 1),(uint)vcell(src, 2),(uint)vcell(src, 3));

        /// <summary>
        /// 4x32w -> 4x64w
        /// 4:32 -> 64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vinflate(Vector128<uint> src, out Vector256<ulong> dst)
            => vconvert(src, out dst);

        // ~ 8x64w <-> 8x32w
        // ~ 8:32 <-> 64
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// (4x64w,4x64w) -> 8x32w
        /// 8:64 -> 32
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vcompact(Vector256<ulong> x0, Vector256<ulong> x1, out Vector256<uint> dst)
            => dst = vconcat(vcompact(x0, out var _), vcompact(x1, out var _));
            
        /// <summary>
        /// 8x32w -> (4x64w,4x64w)
        /// 8:32 -> 64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vinflate(Vector256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            vconvert(vlo(src), out lo);
            vconvert(vhi(src), out hi);
        }
    }
}