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
    using static Memories;    

    partial class dvec
    {
        /// <summary>
        /// Rotates the full 128 bits of a vector rightward a bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to rotate</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vrotrx(Vector128<ulong> src, [Imm] byte count)
            => V0d.vor(vsrlx(src, count), vsllx(src, (byte)(128 - count)));             

        /// <summary>
        /// Rotates each 128 bit lane rightward a bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to rotate</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vrotrx(Vector256<ulong> src, [Imm] byte count)
            => V0d.vor(vsrlx(src, count), vsllx(src, (byte)(128 - count)));             

        /// <summary>
        /// Rotates the full 128-bit vector content leftward by 8 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The count selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vrotlx(Vector128<byte> src, N8 count)
            => V0d.vshuf16x8(src, VData.vrotl(n128, count));   

        /// <summary>
        /// Rotates the full 128-bit vector content leftward by 16 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The count selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vrotlx(Vector128<byte> src, N16 count)
            => V0d.vshuf16x8(src, VData.vrotl(n128, count));

        /// <summary>
        /// Rotates the full 128-bit vector content leftward by 24 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The count selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vrotlx(Vector128<byte> src, N24 count)
            => V0d.vshuf16x8(src, VData.vrotl(n128, count));

        /// <summary>
        /// Rotates the full 128-bit vector content leftward by 32 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The count selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vrotlx(Vector128<byte> src, N32 count)
            => V0d.vshuf16x8(src, VData.vrotl(n128, count));

        /// <summary>
        /// Rotates the full 128-bit vector content rightward by 8 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The count selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vrotrx(Vector128<byte> src, N8 count)
            => V0d.vshuf16x8(src, VData.vrotr(n128, count));

        /// <summary>
        /// Rotates the full 128-bit vector content rightward by 16 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The count selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vrotrx(Vector128<byte> src, N16 count)
            => V0d.vshuf16x8(src, VData.vrotr(n128, count));

        /// <summary>
        /// Rotates the full 128-bit vector content rightward by 24 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The count selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vrotrx(Vector128<byte> src, N24 count)
            => V0d.vshuf16x8(src, VData.vrotr(n128, count));

        /// <summary>
        /// Rotates the full 128-bit vector content rightward by 32 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The count selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vrotrx(Vector128<byte> src, N32 count)
            => V0d.vshuf16x8(src, VData.vrotr(n128, count));
    }
}