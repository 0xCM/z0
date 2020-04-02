//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Core;

    public static class VectorFormatting
    {
        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        public static string FormatBits<T>(this Vector128<T> src, int? maxbits = null,  bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged        
                    => src.ToBitString(maxbits).Format(tlz, specifier, blockWidth ?? bitsize<T>(), blocksep ,rowWidth);
        
        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        public static string FormatBits<T>(this Vector256<T> src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged        
                    => src.ToBitString(maxbits).Format(tlz, specifier, blockWidth ?? bitsize<T>(), blocksep ,rowWidth);        

        /// <summary>
        /// Block-formats the vector, e.g. [01010101 01010101 ... 01010101] where by default the size of each block is the bit-width of a component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        public static string FormatBlockedBits<T>(this Vector128<T> src, int? blocksize = null, int? maxbits = null)
            where T : unmanaged        
                => text.bracket(src.ToBitString(maxbits).Format(false, false, blocksize ?? bitsize<T>(), Chars.Space,null));

        /// <summary>
        /// Block-formats the vector, e.g. [01010101 01010101 ... 01010101] where default the size of each block is the bit-width of a component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        public static string FormatBlockedBits<T>(this Vector256<T> src, int? blocksize = null, int? maxbits = null)
            where T : unmanaged        
                => text.bracket(src.ToBitString(maxbits).Format(false, false, blocksize ?? bitsize<T>(), Chars.Space,null));
    }
}