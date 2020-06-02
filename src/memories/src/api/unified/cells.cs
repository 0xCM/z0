//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        /// <summary>
        /// Counts the number of numeric T-cells that can be convered by contiguous memory of width W
        /// </summary>
        /// <param name="w">The memory bit-width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int cells<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => Widths.cells<W,T>();
    }
}