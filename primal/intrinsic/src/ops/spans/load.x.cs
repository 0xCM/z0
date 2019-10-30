//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static As;

    public static partial class ginxx
    {
        public static Vector256<T> LoadVector<T>(this ReadOnlySpan256<T> src, int block = 0)            
            where T : unmanaged      
        {      
            ginx.vloadu(in src.Block(block), out Vector256<T> x);
            return x;
        }

        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this ReadOnlySpan128<T> src, int block = 0)            
            where T : unmanaged      
        {      
            ginx.vloadu(in src.Block(block), out Vector128<T> x);
            return x;
        }

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this Span<T> src, N128 n, int offset = 0)
            where T : unmanaged            
                => ginx.vloadu(n,in src[offset]);

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this Span<T> src, N256 n, int offset = 0)
            where T : unmanaged            
                => ginx.vloadu(n,in src[offset]);

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this ReadOnlySpan<T> src, N128 n, int offset = 0)
            where T : unmanaged            
                => ginx.vloadu(n,in src[offset]);

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this ReadOnlySpan<T> src, N256 n, int offset = 0)
            where T : unmanaged            
                => ginx.vloadu(n,in src[offset]);

        /// <summary>
        /// Loads a 128-bit vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this Span128<T> src, int block = 0)            
            where T : unmanaged            
                => ginx.vloadu(n128, in src.Block(block));

        /// <summary>
        /// Loads a 256-bit vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this Span256<T> src, int block = 0)            
            where T : unmanaged            
                => ginx.vloadu(n256, in src.Block(block));

    }

}