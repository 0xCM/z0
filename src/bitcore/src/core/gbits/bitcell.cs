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
    
    partial class gbits
    {
        /// <summary>
        /// Queries/manipulates a source cell that covers a position-identified bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The sequence-relative position of the target bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), BitCell, Closures(UnsignedInts)]
        public static ref T bitcell<T>(Span<T> src, BitPos<T> pos)
            where T : unmanaged
                => ref seek(src, pos.CellIndex);

        /// <summary>
        /// Queries/manipulates a source cell that covers a position-identified bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The sequence-relative position of the target bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), BitCell, Closures(UnsignedInts)]
        public static ref readonly T bitcell<T>(ReadOnlySpan<T> src, BitPos<T> pos)
            where T : unmanaged
                => ref skip(src, pos.CellIndex);
    }
}