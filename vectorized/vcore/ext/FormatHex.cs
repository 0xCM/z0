//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    partial class VectorExtensions
    {
        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static string FormatHex<T>(this Vector128<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => VCore.span(src).FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static string FormatHex<T>(this Vector256<T> src, bool bracket = false, char? sep = null, bool specifier = false)
             where T : unmanaged
                => VCore.span(src).FormatHex(bracket,sep, specifier);
    }
}