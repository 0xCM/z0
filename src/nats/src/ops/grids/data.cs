//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Grids
    {

        /// <summary>
        /// Creates a grid over cells of unmanaged type
        /// </summary>
        /// <param name="dim"></param>
        /// <param name="src"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataGrid<T> data<T>(GridDim dim, T[] src)
            where T : unmanaged
                => new DataGrid<T>(dim, src);
    }
}