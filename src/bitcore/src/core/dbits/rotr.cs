//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Bits
    {
        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotr]
        public static byte rotr(byte src, byte offset)
            => (byte)((src >> offset) | (src << (8 - offset)));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotr]
        public static ushort rotr(ushort src, byte offset)
            => (ushort)((src  >> offset) | (src << (16 - offset)));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotr]
        public static uint rotr(uint src, byte offset)
            => (src >> offset) | (src << (32 - offset));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotr]
        public static ulong rotr(ulong src, byte offset)
            => (src >> offset) | (src << (64 - offset));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotr]
        public static byte rotr(byte src, int shift, int width)
            => (byte)((src >> shift) | (src << (width - shift)));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotr]
        public static ushort rotr(ushort src, int shift, int width)
            => (ushort)((src  >> shift) | (src << (width - shift)));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotr]
        public static uint rotr(uint src, int shift, int width)
            => (src >> shift) | (src << (width - shift));

        /// <summary>
        /// Rotates the source bits rightward by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotr]
        public static ulong rotr(ulong src, int shift, int width)
            => (src >> shift) | (src << (width - shift));
    }
}