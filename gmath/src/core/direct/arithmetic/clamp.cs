//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class math
    {
        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static sbyte clamp(sbyte src, sbyte max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static byte clamp(byte src, byte max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static short clamp(short src, short max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static ushort clamp(ushort src, ushort max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static int clamp(int src, int max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static uint clamp(uint src, uint max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static long clamp(long src, long max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static ulong clamp(ulong src, ulong max)
            => src > max ? max : src;

    }
}