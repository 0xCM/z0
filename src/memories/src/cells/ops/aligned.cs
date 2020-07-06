//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Cells
    {
        /// <summary>
        /// Computes the minimum number of w-cells required to evenly cover a grid of bit-dimensions mxn
        /// </summary>
        /// <param name="w">The cellwidth</param>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        [MethodImpl(Inline), Op]
        public static uint aligned(uint m, uint n, uint w)
        {
            var cells = m*n;
            var d = cells/w;
            var r = cells%w; 
            return d + (r != 0 ? 1u : 0u);
        }

    }
}