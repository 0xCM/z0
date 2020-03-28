//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    using static refs;
    
    partial class gbits
    {
        /// <summary>
        /// Queries/manipulates a source cell that covers a position-identified bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The sequence-relative position of the target bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static ref T cell<T>(Span<T> src, BitPos<T> pos)
            where T : unmanaged
                => ref seek(src, pos.CellIndex);

        /// <summary>
        /// Queries/manipulates a source cell that covers a position-identified bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The sequence-relative position of the target bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static ref readonly T cell<T>(ReadOnlySpan<T> src, BitPos<T> pos)
            where T : unmanaged
                => ref skip(src, pos.CellIndex);
    }
}