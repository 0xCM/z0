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
        /// Rotates the source bits leftward by a specified offset amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotl]
        public static byte rotl(byte src, byte offset)
            => (byte)((src << offset) | (src >> (8 - offset)));

        /// <summary>
        /// Rotates the source bits leftward by a specified offset amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotl]
        public static ushort rotl(ushort src, byte offset)
            => (ushort)((src << offset) | (src >> (16 - offset)));

        /// <summary>
        /// Rotates the source bits leftward by a specified offset amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotl]
        public static uint rotl(uint src, byte offset)
            => (src << offset) | (src >> (32 - offset));

        /// <summary>
        /// Rotates the source bits leftward by a specified offset amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotl]
        public static ulong rotl(ulong src, byte offset)
            => (src << offset) | (src >> (64 - offset));

        /// <summary>
        /// Rotates the source bits leftward by a specified offset amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotl]
        public static byte rotl(byte src, byte offset, int width)
            => (byte)((src << offset) | (src >> (width - offset)));

        /// <summary>
        /// Rotates the source bits leftward by a specified offset amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotl]
        public static ushort rotl(ushort src, byte offset, int width)
            => (ushort)((src << offset) | (src >> (width - offset)));

        /// <summary>
        /// Rotates the source bits leftward by a specified offset amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotl]
        public static uint rotl(uint src, byte offset, int width)
            => (src << offset) | (src >> (width - offset));

        /// <summary>
        /// Rotates the source bits leftward by a specified offset amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotl]
        public static ulong rotl(ulong src, byte offset, int width)
            => (src << offset) | (src >> (width - offset));
    }
}