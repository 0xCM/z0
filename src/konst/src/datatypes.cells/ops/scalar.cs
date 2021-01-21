//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Cells
    {
        /// <summary>
        /// Converts a specified cell to a <see cref='byte'/> value
        /// </summary>
        /// <param name="src">The source cell</param>
        [MethodImpl(Inline), Op]
        public static byte primal(Cell8 src)
            =>  (byte)src;

        /// <summary>
        /// Converts a specified cell to a <see cref='ushort'/> value
        /// </summary>
        /// <param name="src">The source cell</param>
        [MethodImpl(Inline), Op]
        public static ushort primal(Cell16 src)
            => (ushort)src;

        /// <summary>
        /// Converts a specified cell to a <see cref='uint'/> value
        /// </summary>
        /// <param name="src">The source cell</param>
        [MethodImpl(Inline), Op]
        public static uint primal(Cell32 src)
            => (uint)src;

        /// <summary>
        /// Converts a specified cell to a <see cref='ulong'/> value
        /// </summary>
        /// <param name="src">The source cell</param>
        [MethodImpl(Inline), Op]
        public static ulong primal(Cell64 src)
            => (ulong)src;
    }
}