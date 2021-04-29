//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XBitBlocks
    {
        /// <summary>
        /// Formats a span as a bitmatrix
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="rowlen">The number of bits in each row</param>
        /// <param name="maxbits">The maximum number of bits to format</param>
        /// <param name="showrow">Indicates whether the content of each row shold be preceded by the row index</param>
        [Op]
        public static string FormatBitRows(this Span<byte> src, int rowlen, int? maxbits = null, bool showrow = false)
            => BitBlocks.format(src, rowlen, maxbits, showrow);

        /// <summary>
        /// Formats the content of a generic span of primal cells as a bitmatrix
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="rowlen">The number of bits in each row</param>
        /// <param name="maxbits">The maximum number of bits to format</param>
        /// <param name="showrow">Indicates whether the content of each row shold be preceded by the row index</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        public static string FormatBitRows<T>(this Span<T> src, int rowlen, int? maxbits = null, bool showrow = false)
            where T : unmanaged
                => BitBlocks.format(src, rowlen, maxbits, showrow);


    }
}