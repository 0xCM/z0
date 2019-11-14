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

    public static class Distribute
    {    
        /// <summary>
        /// 16x8 -> (8x16, 8x16)
        /// </summary>
        /// <param name="src"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        [MethodImpl(Inline)]
        public static void spread(Vector128<byte> src, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            var dst = spread(src, out Vector256<ushort> _);
            lo = vlo(dst);
            hi = vhi(dst);
        }

        /// <summary>
        /// (8x16,8x16) -> 16x8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<byte> compact(Vector128<ushort> x, Vector128<ushort> y)
            => vpackus(x,y);

        /// <summary>
        /// 8x16 -> (4x32,4x32)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        [MethodImpl(Inline)]
        public static void spread(Vector128<ushort> x, out Vector128<uint> lo, out Vector128<uint> hi)
        {
            var dst = spread(x, out Vector256<uint> _);
            lo = vlo(dst);
            hi = vhi(dst);
        }

        /// <summary>
        /// (4x32,4x32) -> 8x16
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> compact(Vector128<uint> x, Vector128<uint> y)
            => vpackus(x,y);

        /// <summary>
        /// (4x32,4x32,4x32,4x32) -> 16x8
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="x3"></param>
        [MethodImpl(Inline)]
        public static Vector128<byte> compact(Vector128<uint> x0, Vector128<uint> x1, Vector128<uint> x2, Vector128<uint> x3)            
        {
            var x = compact(x0,x1);
            var y = compact(x2,x3);
            return compact(x,y);
        }

        /// <summary>
        /// 16x16 -> (8x32, 8x32)
        /// </summary>
        /// <param name="src"></param>
        /// <param name="x0"></param>
        /// <param name="x1"></param>
        [MethodImpl(Inline)]
        public static void spread(Vector256<ushort> src, out Vector256<uint> x0, out Vector256<uint> x1)
        {
            dinx.vconvert(dinx.vlo(src), out x0);
            dinx.vconvert(dinx.vhi(src), out x1);
        }

        /// <summary>
        /// (8x32,8x32) -> 16x16
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> compact(Vector256<uint> x, Vector256<uint> y)            
            => dinx.vpackus(x,y);

        /// <summary>
        /// (16x16,16x16) -> 32x8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<byte> compact(Vector256<ushort> x, Vector256<ushort> y)            
            => dinx.vpackus(x,y);

        /// <summary>
        /// 32x8 -> (8x32, 8x32, 8x32, 8x32)
        /// </summary>
        /// <param name="src"></param>
        /// <param name="x0"></param>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="x3"></param>
        [MethodImpl(Inline)]
        public static void spread(Vector256<byte> src, out Vector256<uint> x0, out Vector256<uint> x1, out Vector256<uint> x2, out Vector256<uint> x3)
        {
            dinx.vconvert(src, out Vector256<ushort> lo, out Vector256<ushort> hi);
            dinx.vconvert(lo, out x0, out x1);
            dinx.vconvert(hi, out x2, out x3);
        }

        /// <summary>
        /// (8x32,8x32,8x32,8x32) -> 32x8
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="x3"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<byte> compact(Vector256<uint> x0, Vector256<uint> x1, Vector256<uint> x2, Vector256<uint> x3)            
        {
            var x = compact(x0,x1);
            var y = compact(x2,x3);
            return compact(x,y);
        }


        /// <summary>
        /// 16x8 -> 16x16
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static ref Vector256<ushort> spread(Vector128<byte> src, out Vector256<ushort> dst)
            => ref dinx.vconvert(src, out dst);

        /// <summary>
        /// 8x16 -> 8x32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vector256<uint> spread(Vector128<ushort> src, out Vector256<uint> dst)
            =>ref dinx.vconvert(src, out dst);

        /// <summary>
        /// 4x32 -> 4x64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vector256<ulong> spread(Vector128<uint> src, out Vector256<ulong> dst)
            =>ref dinx.vconvert(src, out dst);

        /// <summary>
        /// 8x32 -> (4x64,4x64)
        /// </summary>
        /// <param name="src"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        [MethodImpl(Inline)]
        public static void spread(Vector256<uint> src, Vector256<ulong> lo, Vector256<ulong> hi)
        {
            dinx.vconvert(dinx.vlo(src), out lo);
            dinx.vconvert(dinx.vhi(src), out hi);
        }
    }

}