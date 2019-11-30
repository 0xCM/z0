//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// 16x8w -> (8x16w, 8x16w)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vexpand(Vector128<byte> x, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {            
            vconvert(x, out lo);
            vconvert(v8u(vhi(x)), out hi);
        }

        /// <summary>
        /// 16x8w -> 16x16w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vexpand(Vector128<byte> src, out Vector256<ushort> dst)
            => vconvert(src, out dst);

        /// <summary>
        /// 8x16w -> 8x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vexpand(Vector128<ushort> src, out Vector256<uint> dst)
            => vconvert(src, out dst);

        /// <summary>
        /// 8x16w -> (4x32w,4x32w)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vexpand(Vector128<ushort> src, out Vector128<uint> lo, out Vector128<uint> hi)
        {
            vconvert(src, out Vector256<uint> dst);
            lo = vlo(dst);
            hi = vhi(dst);
        }

        /// <summary>
        /// 4x32w -> 4x64w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vexpand(Vector128<uint> src, out Vector256<ulong> dst)
            => vconvert(src, out dst);

        /// <summary>
        /// 16x16w -> (8x32w, 8x32w)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vexpand(Vector256<ushort> src, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            vconvert(vlo(src), out lo);
            vconvert(vhi(src), out hi);
        }

        /// <summary>
        /// 8x32w -> (4x64w,4x64w)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vexpand(Vector256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            vconvert(vlo(src), out lo);
            vconvert(vhi(src), out hi);
        }

        /// <summary>
        /// 32x8w -> (8x32w, 8x32w, 8x32w, 8x32w)
        /// </summary>
        /// <param name="src"></param>
        /// <param name="x0">The first target vector that receives the first 64-bit segment from the source vector </param>
        /// <param name="x1">The second target vector that receives the second 64-bit segment from the source vector</param>
        /// <param name="x2">The third targetvector that receives the third 64-bit segment from the source vector</param>
        /// <param name="x3">The fourth target vector that receives the fourth 64-bit segment from the source vector</param>
        [MethodImpl(Inline)]
        public static void vexpand(Vector256<byte> src, out Vector256<uint> x0, out Vector256<uint> x1, out Vector256<uint> x2, out Vector256<uint> x3)
        {
            vconvert(src, out Vector256<ushort> lo, out Vector256<ushort> hi);
            vconvert(lo, out x0, out x1);
            vconvert(hi, out x2, out x3);
        }
    }
}