//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XHex
    {
        [Op]
        public static string FormatHex(this byte[] src)
            => HexFormat.format(src, HexFormatSpecs.HexData);

        [Op]
        public static string FormatHex(this ReadOnlySpan<byte> src)
            => HexFormat.format(src, HexFormatSpecs.HexData);

        [Op]
        public static string FormatHex(this Span<byte> src)
            => HexFormat.format(src, HexFormatSpecs.HexData);

        [Op]
        public static string FormatHex(this byte[] src, HexFormatOptions config)
            => HexFormat.format(src, config);

        /// <summary>
        /// Formats a span of numeric cell type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [Op, Closures(Closure)]
        public static string FormatHex<T>(this Span<T> src, char sep, bool specifier)
            where T : unmanaged
                => HexFormat.format(src.ReadOnly(), sep, specifier);

        /// <summary>
        /// Formats a span of numeric cell type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [Op, Closures(Closure)]
        public static string FormatHex<T>(this Span<T> src)
            where T : unmanaged
                => HexFormat.format(src.ReadOnly(),Chars.Space, false);

        /// <summary>
        /// Formats a span of numeric cell type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [Op, Closures(Closure)]
        public static string FormatHex<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
                => HexFormat.format(src, Chars.Space, false);

        /// <summary>
        /// Formats a (hopefully finite) stream of values (hopefully numeric) as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [Op, Closures(Closure)]
        public static string FormatHex<T>(this IEnumerable<T> src, char sep, bool specifier)
            where T : unmanaged
                => src.ToSpan().FormatHex(sep, specifier);
    }
}