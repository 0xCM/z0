//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class BitBlocks
    {
        /// <summary>
        /// Formats a span as a bitmatrix
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="rowlen">The number of bits in each row</param>
        /// <param name="maxbits">The maximum number of bits to format</param>
        /// <param name="showrow">Indicates whether the content of each row shold be preceded by the row index</param>
        [Op]
        public static string format(Span<byte> src, int rowlen, int? maxbits = null, bool showrow = false)
        {
            var dst = BitFormatter.chars(src);
            var sb = text.build();
            var limit = maxbits ?? dst.Length;
            for(int i=0, rowidx=0; i<limit; i+= rowlen, rowidx++)
            {
                var remaining = dst.Length - i;
                var segment = math.min(remaining, rowlen);
                var rowbits = dst.Slice(i, segment);
                var rowprefix = showrow ? $"{rowidx.ToString().PadRight(3)} | " : string.Empty;
                var rowformat = rowprefix + new string(rowbits.Intersperse(Chars.Space));
                sb.AppendLine(rowformat);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Formats the content of a generic span of primal cells as a bitmatrix
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="rowlen">The number of bits in each row</param>
        /// <param name="maxbits">The maximum number of bits to format</param>
        /// <param name="showrow">Indicates whether the content of each row shold be preceded by the row index</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        public static string format<T>(Span<T> src, int rowlen, int? maxbits = null, bool showrow = false)
            where T : unmanaged
                => format(src.Bytes(),rowlen, maxbits, showrow);
    }
}