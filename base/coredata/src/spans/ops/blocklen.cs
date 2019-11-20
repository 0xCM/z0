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
        /// Computes the number of elements that comprise a single 64-bit block
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N64 n)
            where T : unmanaged
                => 8/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a single 128-bit block
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N128 n)
            where T : unmanaged
                => 16/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a 256-bit block
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N256 n)
            where T : unmanaged
                => 32/Unsafe.SizeOf<T>();


 
    }

}