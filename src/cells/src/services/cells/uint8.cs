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
        /// Converts a specified cell to a <see cref='byte'/> value
        /// </summary>
        /// <param name="src">The source cell</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(Cell8 src)
            => (byte)src;
    }
}