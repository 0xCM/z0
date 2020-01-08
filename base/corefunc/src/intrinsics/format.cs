//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class xfunc
    {

        /// <summary>
        /// Formats a 128-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string Format<T>(this Vector128<T> src, SeqFmtKind sfmt = SeqFmtKind.List, char sep = ',', int pad = 0, bool bracketed = true)
            where T : unmanaged
        {
            var elements = src.ToSpan();
            return sfmt == SeqFmtKind.Vector 
                ? elements.FormatAsVector(sep.ToString()) 
                : elements.FormatList(sep,0,pad,bracketed);
        }

        /// <summary>
        /// Formats a 256-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string Format<T>(this Vector256<T> src, SeqFmtKind sfmt = SeqFmtKind.List, char sep = ',', int pad = 0, bool bracketed = true,  bool seplanes = false)
            where T : unmanaged
        {
            if(seplanes)
                return $"{src.GetLower().Format(sfmt, sep, pad)} {src.GetUpper().Format(sfmt, sep, pad)}";
            else
            {
                var elements = src.ToSpan();
                return sfmt == SeqFmtKind.Vector 
                    ? elements.FormatAsVector(sep.ToString()) 
                    : elements.FormatList(sep,0,pad,bracketed);
            }
        }

        /// <summary>
        /// Formats vector content for console/file output
        /// </summary>
        /// <param name="src">The vector to format</param>
        /// <param name="sep">The component separator</param>
        /// <param name="pad">The per-component padding</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static string FormatList<T>(this Vector128<T> src, char sep = ',', int pad = 0, bool bracketed = true)
            where T : unmanaged
                => src.Format(SeqFmtKind.List, sep, pad, bracketed);

        /// <summary>
        /// Formats vector content for console/file output
        /// </summary>
        /// <param name="src">The vector to format</param>
        /// <param name="sep">The component separator</param>
        /// <param name="pad">The per-component padding</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static string FormatList<T>(this Vector256<T> src, char sep = ',', int pad = 0, bool bracketed = true)
            where T : unmanaged
                => src.Format(SeqFmtKind.List,sep,pad, bracketed);

        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBits<T>(this Vector128<T> src, int? maxbits = null,  bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged        
                    => src.ToBitString(maxbits).Format(tlz, specifier, blockWidth ?? bitsize<T>(), blocksep ,rowWidth);
        
        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBits<T>(this Vector256<T> src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged        
                    => src.ToBitString(maxbits).Format(tlz, specifier, blockWidth ?? bitsize<T>(), blocksep ,rowWidth);        

        /// <summary>
        /// Block-formats the vector, e.g. [01010101 01010101 ... 01010101] where by default the size of each block is the bit-width of a component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBlockedBits<T>(this Vector128<T> src, int? blocksize = null, int? maxbits = null)
            where T : unmanaged        
                => bracket(src.ToBitString(maxbits).Format(false, false, blocksize ?? bitsize<T>(), AsciSym.Space,null));

        /// <summary>
        /// Block-formats the vector, e.g. [01010101 01010101 ... 01010101] where default the size of each block is the bit-width of a component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBlockedBits<T>(this Vector256<T> src, int? blocksize = null, int? maxbits = null)
            where T : unmanaged        
                => bracket(src.ToBitString(maxbits).Format(false, false, blocksize ?? bitsize<T>(), AsciSym.Space,null));
    }
}