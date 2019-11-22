//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Covers an unblocked span with 64-bit blocks, raising an error if the source span bit length is not evenly divisible by 128
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> transfer<T>(N64 n, Span<T> src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n,src.Length);
                
            return new Block64<T>(src);
        }        

        /// <summary>
        /// Covers an unblocked span with 128-bit blocks, raising an error if the source span bit length is not evenly divisible by 128
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> transfer<T>(N128 n, Span<T> src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n,src.Length);

            return new Block128<T>(src);
        }        

        /// <summary>
        /// Covers an unblocked span with 256-bit blocks, raising an error if the source span bit length is not evenly divisible by 256
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> transfer<T>(N256 n, Span<T> src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n,src.Length);

            return new Block256<T>(src);
        }        
    }
}