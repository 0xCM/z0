//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    
    using static Root;

    partial class math
    {
         /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static sbyte sal(sbyte src, byte offset)        
            => (sbyte)(src << offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static byte sal(byte src, byte offset)
            => (byte)(src << offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static short sal(short src, byte offset)
            => (short)(src << offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static ushort sal(ushort src, byte offset)
            => (ushort)(src << offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static int sal(int src, byte offset)
            => src << offset;

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static uint sal(uint src, byte offset)
            => src << offset;

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static long sal(long src, byte offset)
            => src << offset;

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static ulong sal(ulong src, byte offset)
            => src << offset;
    }
}