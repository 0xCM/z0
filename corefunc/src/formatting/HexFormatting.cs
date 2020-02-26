//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;    

    public static class HexFormattingX
    {
        const string UC = "X";

        const string LC = "x";

        const int HexPad8 = 2;

        const int HexPad16 = 4;

        const int HexPad32 = 8;

        const int HexPad64 = 16;


        /// <summary>
        /// Formats a span of natural length and integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<N,T>(this NatSpan<N,T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vector128<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.ToSpan().FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vector256<T> src, bool bracket = false, char? sep = null, bool specifier = false)
             where T : unmanaged
                => src.ToSpan().FormatHex(bracket,sep, specifier);
   }
}