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

    partial class MemBlocks
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
        public static Span128<T> transfer<T>(N128 n, Span<T> src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n,src.Length);
            return new Span128<T>(src);
        }        

        /// <summary>
        /// Covers an unblocked span with 256-bit blocks, raising an error if the source span bit length is not evenly divisible by 256
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> transfer<T>(N256 n, Span<T> src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n,src.Length);
            return new Span256<T>(src);
        }        

        /// <summary>
        /// Covers an unblocked span with 64-bit blocks with no size checks
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        internal static Block64<T> transferunsafe<T>(N64 n, Span<T> src)
            where T : unmanaged        
                => new Block64<T>(src);

        /// <summary>
        /// Covers an unblocked span with 128-bit blocks with no size checks
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span128<T> transferunsafe<T>(N128 n, Span<T> src)
            where T : unmanaged        
                => new Span128<T>(src);

        /// <summary>
        /// Covers an unblocked span with 128-bit blocks with no size checks
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span256<T> transferunsafe<T>(N256 n, Span<T> src)
            where T : unmanaged        
                => new Span256<T>(src);

    }
}