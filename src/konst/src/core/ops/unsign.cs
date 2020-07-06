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
        /// Converts a <see cref='sbyte'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte unsign(sbyte src)
            => (byte)src;

        /// <summary>
        /// Converts a <see cref='short'/> to a <see cref='ushort'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ushort unsign(short src)
            => (ushort)src;

        /// <summary>
        /// Converts a <see cref='int'/> to a <see cref='uint'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint unsign(int src)
            => (uint)src;

        /// <summary>
        /// Converts a <see cref='long'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ulong unsign(long src)
            => (ulong)src;
    }
}