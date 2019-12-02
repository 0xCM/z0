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
        /// Allocates a single 16-bit block
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> single<T>(N16 n)
            where T : unmanaged        
                => alloc<T>(n,1);

        /// <summary>
        /// Allocates a single 32-bit block
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> single<T>(N32 n)
            where T : unmanaged        
                => alloc<T>(n,1);

        /// <summary>
        /// Allocates a single 64-bit block
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> single<T>(N64 n)
            where T : unmanaged        
                => alloc<T>(n,1);

        /// <summary>
        /// Allocates a single 128-bit block
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> single<T>(N128 n)
            where T : unmanaged        
                => alloc<T>(n,1);

        /// <summary>
        /// Allocates a single 256-bit block
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> single<T>(N256 n)
            where T : unmanaged        
                => alloc<T>(n,1);
    }
}