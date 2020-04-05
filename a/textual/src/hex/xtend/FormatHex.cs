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
        public static string FormatHex<T>(this ReadOnlySpan<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
        {
            var delimiter = sep ?? Chars.Space;
            var builder = string.Empty.Build();
            if(bracket)
                builder.Append(Chars.LBracket);

            for(var i = 0; i<src.Length; i++)
            {
                builder.Append(Hex.format(src[i], true, specifier));
                if(i != src.Length - 1)
                    builder.Append((char)delimiter);
            }
            
            if(bracket)
                builder.Append(Chars.RBracket);
            
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
        public static string FormatHex<T>(this Span<T> src, bool bracket, char? sep, bool specifier)
            where T : unmanaged
                => src.ReadOnly().FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a (hopefully finite) stream of values (hopefully numeric) as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this IEnumerable<T> src, bool bracket, char sep, bool specifier)
            where T : unmanaged
                => src.ToSpan().FormatHex(bracket, sep, specifier);
    }
}