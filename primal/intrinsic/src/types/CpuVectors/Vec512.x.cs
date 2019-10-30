//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;
    
    using static zfunc;    

    public static class Vec512x
    {
        /// <summary>
        /// Allocates a span and extracts
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this in Vec512<T> src)
            where T : unmanaged            
        {
            var dst = span<T>(Vec512<T>.Length);
            src.ToSpan(dst);
            return dst;
        }                       



        /// <summary>
        /// Copies the source data to a specified span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static void ToSpan<T>(this in Vec512<T> src, Span<T> dst)
            where T : unmanaged            
        {
            vstore(src.lo, ref dst[0]);
            vstore(src.hi, ref dst[Vec256<T>.Length]);
        }       

        /// <summary>
        /// Represents the vector content as a span (Non-allocating)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static unsafe Span<T> AsSpan<T>(this ref Vec512<T> src)
            where T : unmanaged            
                => new Span<T>(Unsafe.AsPointer(ref src), Vec512<T>.Length);

        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec512<T> src, int? bwidth = null, char? bsep = null)
            where T : unmanaged
                => src.hi.ToSpan().FormatHexBlocks(bwidth, bsep) 
                    + src.lo.ToSpan().FormatHexBlocks(bwidth, bsep);
    }

}