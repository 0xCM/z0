//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// Rotates the full 128 bits of a vector rightward a bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to rotate</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotrx(Vector128<ulong> src, byte shift)
            => vor(vsrlx(src, shift), vsllx(src, (byte)(128 - shift)));             

        /// <summary>
        /// Rotates each 128 bit lane rightward a bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to rotate</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotrx(Vector256<ulong> src, byte shift)
            => vor(vsrlx(src, shift), vsllx(src, (byte)(128 - shift)));             

        /// <summary>
        /// Rotates the full 128-bit vector content leftward by 8 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The shift selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotlx(Vector128<byte> src, N8 shift)
            => vshuf16x8(src, VData.rotl(n128, shift));   

        /// <summary>
        /// Rotates the full 128-bit vector content leftward by 16 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The shift selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotlx(Vector128<byte> src, N16 shift)
            => vshuf16x8(src, VData.rotl(n128, shift));

        /// <summary>
        /// Rotates the full 128-bit vector content leftward by 24 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The shift selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotlx(Vector128<byte> src, N24 shift)
            => vshuf16x8(src, VData.rotl(n128, shift));

        /// <summary>
        /// Rotates the full 128-bit vector content leftward by 32 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The shift selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotlx(Vector128<byte> src, N32 shift)
            => vshuf16x8(src, VData.rotl(n128, shift));

        /// <summary>
        /// Rotates the full 128-bit vector content rightward by 8 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The shift selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotrx(Vector128<byte> src, N8 shift)
            => vshuf16x8(src, VData.rotr(n128, shift));

        /// <summary>
        /// Rotates the full 128-bit vector content rightward by 16 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The shift selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotrx(Vector128<byte> src, N16 shift)
            => vshuf16x8(src, VData.rotr(n128, shift));

        /// <summary>
        /// Rotates the full 128-bit vector content rightward by 24 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The shift selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotrx(Vector128<byte> src, N24 shift)
            => vshuf16x8(src, VData.rotr(n128, shift));

        /// <summary>
        /// Rotates the full 128-bit vector content rightward by 32 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The shift selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotrx(Vector128<byte> src, N32 shift)
            => vshuf16x8(src, VData.rotr(n128, shift));
    }
}