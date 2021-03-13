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
        /// Creates a <see cref='Cell32'/> from a specified <see cref='int'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell32 cell32(int src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell32'/> from a specified <see cref='uint'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell32 cell32(uint src)
            => src;
    }
}