//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class math
    {
        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static sbyte inc(sbyte src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static byte inc(byte src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static short inc(short src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static ushort inc(ushort src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static int inc(int src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static uint inc(uint src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static long inc(long src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static ulong inc(ulong src)
            => ++src;

        /// <summary>
        /// Increments the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static float inc(float src)
            => ++src;

        /// <summary>
        /// Increments the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static double inc(double src)
            => ++src;
    }
}