//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Text;
    
    using static zfunc;    

    partial class xfunc
    {
        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vector128<T> src, bool vectorize = true, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.ToSpan().FormatHex(vectorize, sep, specifier);

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vector256<T> src, bool vectorize = true, char? sep = null, bool specifier = false)
             where T : unmanaged
                => src.ToSpan().FormatHex(vectorize,sep, specifier); 
                
        /// <summary>
        /// Formats vector components as blocked hex
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Vector128<T> src)
            where T : unmanaged
                => src.FormatHex(false, AsciSym.Space);

        /// <summary>
        /// Formats vector components as blocked hex
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Vector256<T> src)
            where T : unmanaged
                => src.FormatHex(false, AsciSym.Space);

        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBits<T>(this Vector128<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null)
            where T : unmanaged        
                => src.ToBitString().Format(tlz, specifier, blockWidth, blocksep);
        
        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBits<T>(this Vector256<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null)
            where T : unmanaged        
                => src.ToBitString().Format(tlz, specifier, blockWidth, blocksep);

        /// <summary>
        /// Formats each vector component as a distinct bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBitBlocks<T>(this Vector128<T> src)
            where T : unmanaged
                => src.FormatBits(false,false,bitsize<T>());

        /// <summary>
        /// Formats each vector component as a distinct bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBitBlocks<T>(this Vector256<T> src)
            where T : unmanaged
                => src.FormatBits(false,false,bitsize<T>());
    }
}