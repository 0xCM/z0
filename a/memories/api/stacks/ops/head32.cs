//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class Stacked
    {
        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref uint head32(ref MemStack32 src)
            => ref src.X0;
    }
}