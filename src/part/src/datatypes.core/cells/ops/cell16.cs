//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Cells
    {
        /// <summary>
        /// Creates a <see cref='Cell16'/> from a specified <see cref='short'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell16 cell16(short src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell16'/> from a specified <see cref='ushort'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell16 cell16(ushort src)
            => src;
    }
}