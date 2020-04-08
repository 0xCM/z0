//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;
    
    partial class Bits
    {                
        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotl]
        public static byte rotl(byte src, byte shift)
            => (byte)((src << shift) | (src >> (8 - shift)));

        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotl]
        public static ushort rotl(ushort src, byte shift)
            => (ushort)((src << shift) | (src >> (16 - shift)));

        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotl]
        public static uint rotl(uint src, byte shift)
            => (src << shift) | (src >> (32 - shift));

        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline), Rotl]
        public static ulong rotl(ulong src, byte shift)
            => (src << shift) | (src >> (64 - shift));

        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotl]
        public static byte rotl(byte src, byte shift, int width)
            => (byte)((src << shift) | (src >> (width - shift)));

        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotl]
        public static ushort rotl(ushort src, byte shift, int width)
            => (ushort)((src << shift) | (src >> (width - shift)));

        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotl]
        public static uint rotl(uint src, byte shift, int width)
            => (src << shift) | (src >> (width - shift));

        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Rotl]
        public static ulong rotl(ulong src, byte shift, int width)
            => (src << shift) | (src >> (width - shift));
    }
}