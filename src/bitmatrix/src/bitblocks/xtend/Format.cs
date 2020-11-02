//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
        public static string FormatMatrixBits(this Span<byte> src, int rowlen, int? maxbits = null, bool showrow = false)
        {
            var dst = BitString.bitchars(src);
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
        public static string FormatMatrixBits<T>(this Span<T> src, int rowlen, int? maxbits = null, bool showrow = false)
            where T : unmanaged
                => src.Bytes().FormatMatrixBits(rowlen, maxbits, showrow);


        [MethodImpl(Inline)]
        public static string Format<N,T>(this BitBlock<N,T> src, BitFormat? config = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToBitString().Format(config);
    }
}