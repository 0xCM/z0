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

        /// <summary>
        /// (8x16w,8x16w) -> 16x8w
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector128<ushort> x, Vector128<ushort> y)
            => vpackus(x,y);

        /// <summary>
        /// (8x16w,8x16w) -> 16x8w
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector128<ushort> x, Vector128<ushort> y, out Vector128<byte> dst)
            => dst = vcompact(x,y);

        /// <summary>
        /// (16x16w,16x16w) -> 32x8w
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vcompact(Vector256<ushort> x, Vector256<ushort> y)            
            => vperm4x64(vpackus(x,y), Perm4.ACBD);

        /// <summary>
        /// (16x16w,16x16w) -> 32x8w
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vcompact(Vector256<ushort> x, Vector256<ushort> y, out Vector256<byte> dst)            
            => dst = vcompact(x,y);

        /// <summary>
        /// 16x16w -> 16x8w
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector256<ushort> x, out Vector128<byte> dst)            
            => dst = vcompact(vlo(x),vhi(x));

        /// <summary>
        /// (4x32w,4x32w) -> 8x16w
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vcompact(Vector128<uint> x, Vector128<uint> y)
            => vpackus(x,y);

        /// <summary>
        /// 8x32w -> 8x16w
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vcompact(Vector256<uint> x, out Vector128<ushort> dst)            
            => dst = vcompact(vlo(x),vhi(x));

        /// <summary>
        /// (4x32w,4x32w) -> 8x16w
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vcompact(Vector128<uint> x, Vector128<uint> y, out Vector128<ushort> dst)
            => dst = vcompact(x,y);

        /// <summary>
        /// (8x32w,8x32w) -> 16x16w
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
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vcompact(Vector256<uint> x, Vector256<uint> y, out Vector256<ushort> dst)            
            => dst = vcompact(x,y);            

        /// <summary>
        /// (4x32w,4x32w,4x32w,4x32w) -> 16x8w
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
        /// (4x32w,4x32w,4x32w,4x32w) -> 16x8w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcompact(Vector128<uint> x0, Vector128<uint> x1, Vector128<uint> x2, Vector128<uint> x3, out Vector128<byte> dst)            
            => dst = vcompact(x0,x1,x2,x3);

        /// <summary>
        /// (8x32w,8x32w,8x32w,8x32w) -> 32x8w
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
        /// (8x32w,8x32w,8x32w,8x32w) -> 32x8w
        /// </summary>
        /// <param name="x0">The first source vector</param>
        /// <param name="x1">The second source vector</param>
        /// <param name="x2">The third source vector</param>
        /// <param name="x3">The fourth source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vcompact(Vector256<uint> x0, Vector256<uint> x1, Vector256<uint> x2, Vector256<uint> x3, out Vector256<byte> dst)            
            => dst = vcompact(x0,x1,x2,x3);


    }
}