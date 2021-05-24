//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Cells
    {
        /// <summary>
        /// Creates a <see cref='Cell64'/> from a specified <see cref='long'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell64 cell64(long src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell64'/> from a specified <see cref='ulong'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell64 cell64(ulong src)
            => src;
    }
}