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
    
    using static zfunc;    
    
    partial class math
    {
        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static sbyte inc(sbyte src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte inc(byte src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static short inc(short src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ushort inc(ushort src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static int inc(int src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint inc(uint src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static long inc(long src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ulong inc(ulong src)
            => ++src;
    }
}