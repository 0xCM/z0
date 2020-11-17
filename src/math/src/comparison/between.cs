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
        /// Defines the test between:bit := (x >= min) && (x <= max)
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Between]
        public static bool between(byte src, byte min, byte max)
            => src >= min && src <= max;

        /// <summary>
        /// Defines the test between:bit := (x >= min) && (x <= max)
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Between]
        public static bool between(sbyte src, sbyte min, sbyte max)
            => src >= min && src <= max;

        /// <summary>
        /// Defines the test between:bit := (x >= min) && (x <= max)
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Between]
        public static bool between(short src, short min, short max)
            => src >= min && src <= max;

        /// <summary>
        /// Defines the test between:bit := (x >= min) && (x <= max)
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Between]
        public static bool between(ushort src, ushort min, ushort max)
            => src >= min && src <= max;

        /// <summary>
        /// Defines the test between:bit := (x >= min) && (x <= max)
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Between]
        public static bool between(int src, int min, int max)
            => src >= min && src <= max;

        /// <summary>
        /// Defines the test between:bit := (x >= min) && (x <= max)
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Between]
        public static bool between(uint src, uint min, uint max)
            => src >= min && src <= max;

        /// <summary>
        /// Defines the test between:bit := (x >= min) && (x <= max)
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Between]
        public static bool between(long src, long min, long max)
            => src >= min && src <= max;

        /// <summary>
        /// Defines the test between:bit := (x >= min) && (x <= max)
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Between]
        public static bool between(ulong src, ulong min, ulong max)
            => src >= min && src <= max;
    }
}