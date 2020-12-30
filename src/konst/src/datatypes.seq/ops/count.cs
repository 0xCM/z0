//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Seq
    {
        /// <summary>
        /// Tests the source index for non-emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(in DataIndex<T> src)
            where T : struct
                => (uint)(src.Data?.Length ?? 0);
    }
}