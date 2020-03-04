//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    
    partial class Bits
    {                

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static byte rotr(byte src, int shift)
            => (byte)((src >> shift) | (src << (8 - shift)));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static ushort rotr(ushort src, int shift)
            => (ushort)((src  >> shift) | (src << (16 - shift)));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static uint rotr(uint src, int shift)
            => (src >> shift) | (src << (32 - shift));


        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static ulong rotr(ulong src, int shift)
            => (src >> shift) | (src << (64 - shift));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Op]
        public static byte rotr(byte src, int shift, int width)
            => (byte)((src >> shift) | (src << (width - shift)));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Op]
        public static ushort rotr(ushort src, int shift, int width)
            => (ushort)((src  >> shift) | (src << (width - shift)));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Op]
        public static uint rotr(uint src, int shift, int width)
            => (src >> shift) | (src << (width - shift));


        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Op]
        public static ulong rotr(ulong src, int shift, int width)
            => (src >> shift) | (src << (width - shift));

 
    }

}