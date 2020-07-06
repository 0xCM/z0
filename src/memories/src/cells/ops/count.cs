//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct GridCells
    {
        /// <summary>
        /// Computes the number of packed cells required to cover a rectangular area
        /// </summary>
        /// <param name="rows">The grid row count</param>
        /// <param name="cols">The grid col count</param>
        /// <param name="w">The storage cell width</param>
        [MethodImpl(Inline), Op]
        public static int count(ulong rows, ulong cols, int w)
        {
            var sz = (int)bytes(rows, cols);
            var segbytes = w / 8;
            var segs = sz/segbytes + (sz % segbytes != 0 ? 1 : 0);            
            return segs;
        }
    }
}