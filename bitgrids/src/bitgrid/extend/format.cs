//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class BitGridX
    {
        /// <summary>
        /// Formats a span as a bitmatrix
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="rowlen">The number of bits in each row</param>
        /// <param name="maxbits">The maximum number of bits to format</param>
        /// <param name="showrow">Indicates whether the content of each row shold be preceded by the row index</param>
        internal static string FormatMatrixBits(this Span<byte> src, int rowlen, int? maxbits = null, bool showrow = false) 
        {
            var dst = BitString.bitchars(src);
            var sb = text.factory.Builder();
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
        internal static string FormatMatrixBits<T>(this Span<T> src, int rowlen, int? maxbits = null, bool showrow = false)
            where T : unmanaged
                => src.AsBytes().FormatMatrixBits(rowlen, maxbits, showrow);

        public static string Format<T>(this BitGrid<T> src, bool showrow = false, int? maxbits = null)
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<T>(this BitGrid32<T> src, int? cols = null, bool showrow = false, int? maxbits = null)
            where T : unmanaged
                => BitGrid.format(src, cols, showrow, maxbits);

        public static string Format<T>(this BitGrid64<T> src, int? cols = null, bool showrow = false, int? maxbits = null)
            where T : unmanaged
                => BitGrid.format(src, cols, showrow, maxbits);

        public static string Format<M,N,T>(this BitGrid<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this BitGrid16<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this BitGrid32<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this BitGrid64<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this BitGrid128<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this BitGrid256<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this SubGrid16<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this SubGrid32<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this SubGrid64<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this SubGrid128<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

        public static string Format<M,N,T>(this SubGrid256<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src, showrow, maxbits);

    }
}