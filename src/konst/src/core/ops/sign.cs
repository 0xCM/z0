//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {
        /// <summary>
        /// Converts a <see cref='byte'/> to a <see cref='sbyte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static sbyte sign(byte src)
            => (sbyte)src;

        /// <summary>
        /// Converts a <see cref='ushort'/> to a <see cref='short'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static short sign(ushort src)
            => (short)src;

        /// <summary>
        /// Converts a <see cref='uint'/> to a <see cref='int'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static int sign(uint src)
            => (int)src;

        /// <summary>
        /// Converts a <see cref='ulong'/> to a <see cref='long'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static long sign(ulong src)
            => (long)src;
    }
}