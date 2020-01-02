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
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte sal(sbyte src, int offset)        
            => (sbyte)(src << offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static byte sal(byte src, int offset)
            => (byte)(src << offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static short sal(short src, int offset)
            => (short)(src << offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ushort sal(ushort src, int offset)
            => (ushort)(src << offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static int sal(int src, int offset)
            => src << offset;

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint sal(uint src, int offset)
            => src << offset;

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static long sal(long src, int offset)
            => src << offset;

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ulong sal(ulong src, int offset)
            => src << offset;
 

    }

}