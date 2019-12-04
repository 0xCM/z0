//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class PermX
    {

        /// <summary>
        /// Applies a sequence of transpositions to source span elements
        /// </summary>
        /// <param name="src">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Swap<T>(this Span<T> src, params Swap[] swaps)           
            where T : unmanaged
        {
            var len = swaps.Length;
            ref var srcmem = ref head(src);
            ref var swapmem = ref head(swaps);
            for(var k = 0; k < len; k++)
            {
                (var i, var j) = skip(in swapmem, k);
                swap(ref seek(ref srcmem, i), ref seek(ref srcmem, j));
            }
            return src;
        }

        /// <summary>
        /// Applies a sequence of transpositions to a blocked container
        /// </summary>
        /// <param name="src">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Swap<T>(this Block128<T> src, params Swap[] swaps)           
            where T : unmanaged
        {
             if(swaps == null || swaps.Length == 0)
                return src;
                
             src.Data.Swap(swaps);
             return src;
        }        

        /// <summary>
        /// Applies a sequence of transpositions to a blocked container
        /// </summary>
        /// <param name="src">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Swap<T>(this Block256<T> src, params Swap[] swaps)           
            where T : unmanaged
        {
             if(swaps == null || swaps.Length == 0)
                return src;

             src.Data.Swap(swaps);
             return src;
        }
    }
}