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
        /// Determines whether a specified number of elements can be evenly covered by 64-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(N64 n, int count)
            where T : unmanaged        
                => count % blocklen<T>(n) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 128-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(N128 n, int count)
            where T : unmanaged        
                => count % blocklen<T>(n) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 256-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(N256 n, int count)
            where T : unmanaged        
                => count % blocklen<T>(n) == 0;

    }
}