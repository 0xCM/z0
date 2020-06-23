//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class BitGrid
    {
        /// <summary>
        /// Fills a caller-allocated generic grid
        /// </summary>
        /// <param name="cell">The data to replicate across all grid cells</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Broadcast, Closures(UnsignedInts)]
        public static ref readonly BitGrid<T> broadcast<T>(T cell, in BitGrid<T> dst)            
            where T : unmanaged
        {
            dst.Content.Fill(cell);
            return ref dst;
        }
    }
}