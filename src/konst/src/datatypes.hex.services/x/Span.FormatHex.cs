//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    partial class XTend
    {
        /// <summary>
        /// Formats a span pf presumed integral values as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to format the result as a vector</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this ReadOnlySpan<T> src,  char sep = Chars.Space, bool specifier = false)
            where T : unmanaged
        {
            var builder = text.build();

            for(var i = 0; i<src.Length; i++)
            {
                builder.Append(Hex.format(src[i], true, specifier));
                if(i != src.Length - 1)
                    builder.Append(sep);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Formats a span of numeric cell type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this Span<T> src, char sep, bool specifier)
            where T : unmanaged
                => src.ReadOnly().FormatHex(sep, specifier);

        /// <summary>
        /// Formats a span of numeric cell type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this Span<T> src)
            where T : unmanaged
                => src.ReadOnly().FormatHex(Chars.Space, false);

        /// <summary>
        /// Formats a span of numeric cell type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
                => src.FormatHex(Chars.Space, false);

        /// <summary>
        /// Formats a (hopefully finite) stream of values (hopefully numeric) as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this IEnumerable<T> src, char sep, bool specifier)
            where T : unmanaged
                => src.ToSpan().FormatHex(sep, specifier);

        /// <summary>
        /// Formats a span of natural length and integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<N,T>(this NatSpan<N,T> src, char sep = Chars.Space, bool specifier = false)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Edit.FormatHex(sep, specifier);
    }
}