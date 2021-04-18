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
        /// Creates a <see cref='Cell8'/> from a specified <see cref='byte'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell8 cell8(byte src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell8'/> from a specified <see cref='sbyte'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell8 cell8(sbyte src)
            => src;
    }
}