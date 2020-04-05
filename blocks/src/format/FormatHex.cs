//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class XBlocks
    {
        /// <summary>
        /// Formats a blocked sequence as a sequence of hex values
        /// </summary>
        /// <param name="src">The source block</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this Block64<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.Data.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a 128-bit blocked span as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this Block128<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.Data.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a span of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this Block256<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.Data.FormatHex(bracket, sep, specifier);
    }
}