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
    using static dinx;

    partial class dinx
    {
        /// <summary>
        /// 16x8 -> (8x16, 8x16)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vspread(Vector128<byte> x, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {            
            vconvert(x, out lo);
            vconvert(v8u(vhi(x)), out hi);
        }

        /// <summary>
        /// (8x16,8x16) -> 16x8
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector128<ushort> x, Vector128<ushort> y)
            => vpackus(x,y);

        /// <summary>
        /// 16x8 -> 16x16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vspread(Vector128<byte> src, out Vector256<ushort> dst)
            => vconvert(src, out dst);

        /// <summary>
        /// (16x16,16x16) -> 32x8
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vcompact(Vector256<ushort> x, Vector256<ushort> y)            
            => vpackus(x,y);

        /// <summary>
        /// 8x16 -> (4x32,4x32)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vspread(Vector128<ushort> src, out Vector128<uint> lo, out Vector128<uint> hi)
        {
            vconvert(src, out Vector256<uint> dst);
            lo = vlo(dst);
            hi = vhi(dst);
        }

        /// <summary>
        /// 8x16 -> 8x32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vspread(Vector128<ushort> src, out Vector256<uint> dst)
            => vconvert(src, out dst);

        /// <summary>
        /// (4x32,4x32) -> 8x16
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vcompact(Vector128<uint> x, Vector128<uint> y)
            => vpackus(x,y);

        /// <summary>
        /// 16x16 -> (8x32, 8x32)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline)]
        public static void vspread(Vector256<ushort> src, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            vconvert(vlo(src), out lo);
            vconvert(vhi(src), out hi);
        }

        /// <summary>
        /// (8x32,8x32) -> 16x16
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vcompact(Vector256<uint> x, Vector256<uint> y)            
            => vpackus(x,y);

        /// <summary>
        /// (4x32,4x32,4x32,4x32) -> 16x8
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector128<uint> x0, Vector128<uint> x1, Vector128<uint> x2, Vector128<uint> x3)            
        {
            var x = vcompact(x0,x1);
            var y = vcompact(x2,x3);
            return vcompact(x,y);
        }

        /// <summary>
        /// 32x8 -> (8x32, 8x32, 8x32, 8x32)
        /// </summary>
        /// <param name="src"></param>
        /// <param name="x0">The first target vector that receives the first 64-bit segment from the source vector </param>
        /// <param name="x1">The second target vector that receives the second 64-bit segment from the source vector</param>
        /// <param name="x2">The third targetvector that receives the third 64-bit segment from the source vector</param>
        /// <param name="x3">The fourth target vector that receives the fourth 64-bit segment from the source vector</param>
        [MethodImpl(Inline)]
        public static void vspread(Vector256<byte> src, out Vector256<uint> x0, out Vector256<uint> x1, out Vector256<uint> x2, out Vector256<uint> x3)
        {
            vconvert(src, out Vector256<ushort> lo, out Vector256<ushort> hi);
            vconvert(lo, out x0, out x1);
            vconvert(hi, out x2, out x3);
        }

        /// <summary>
        /// (8x32,8x32,8x32,8x32) -> 32x8
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vcompact(Vector256<uint> x0, Vector256<uint> x1, Vector256<uint> x2, Vector256<uint> x3)            
        {
            var x = vcompact(x0,x1);
            var y = vcompact(x2,x3);
            return vcompact(x,y);
        }

        /// <summary>
        /// 4x32 -> 4x64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vspread(Vector128<uint> src, out Vector256<ulong> dst)
            => vconvert(src, out dst);

        /// <summary>
        /// 8x32 -> (4x64,4x64)
        /// </summary>
        /// <param name="src"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        [MethodImpl(Inline)]
        public static void vspread(Vector256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            vconvert(vlo(src), out lo);
            vconvert(vhi(src), out hi);
        }
    }
}