//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    partial class XTend
    {
        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        public static string FormatBits<T>(this Vector128<T> src, int? maxbits = null,  bool tlz = false, bool specifier = false, int? blockWidth = null,
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged
                    => src.ToBitString(maxbits).Format(BitFormatOptions.define(tlz, specifier, blockWidth, blocksep, rowWidth,null));

        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        public static string FormatBits<T>(this Vector256<T> src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockWidth = null,
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged
                    =>  src.ToBitString(maxbits).Format(BitFormatOptions.define(tlz, specifier, blockWidth, blocksep, rowWidth,null));
    }
}