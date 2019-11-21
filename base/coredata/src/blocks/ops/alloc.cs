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
        /// Allocates a 64-bit 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> alloc<T>(N64 n)
            where T : unmanaged        
                => Block64<T>.AllocBlocks(1);

        /// <summary>
        /// Allocates a 128-bit 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> alloc<T>(N128 n)
            where T : unmanaged        
                => Block128<T>.AllocBlocks(1);

        /// <summary>
        /// Allocates a 256-bit 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> alloc<T>(N256 n)
            where T : unmanaged        
                => Block256<T>.AllocBlocks(1);

        /// <summary>
        /// Allocates a 64-bit 1-block span filled with a specified pattern
        /// </summary>
        /// <param name="fill">A value used to initialize each cell</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> alloc<T>(N64 n, T fill)
            where T : unmanaged        
                => Block64<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a 128-bit 1-block span filled with a specified pattern
        /// </summary>
        /// <param name="fill">A value used to initialize each cell</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> alloc<T>(N128 n, T fill)
            where T : unmanaged        
                => Block128<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a 256-bit 1-block span filled with a specified pattern
        /// </summary>
        /// <param name="fill">A value used to initialize each cell</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> alloc<T>(N256 n, T fill)
            where T : unmanaged        
                => Block256<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a specified number of 64-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> alloc<T>(N64 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Block64<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a specified number of 128-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> alloc<T>(N128 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Block128<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a specified number of 256-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> alloc<T>(N256 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Block256<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates the minimum amount of memory required to align matrix/tabular data in 64-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> allocu<T>(N64 n, int rowcount, int colcount, T fill = default)
            where T : unmanaged
                => alloc<T>(n, blockalign<T>(n, rowcount*colcount), fill);

        /// <summary>
        /// Allocates a 256-bit blocked span of a specified minimum length which may not partition evently into 256-bit blocks
        /// </summary>
        /// <param name="cellcount">The number of cells that require coverage</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Block64<T> allocu<T>(N64 n, int cellcount, T fill = default)
            where T : unmanaged        
                => alloc<T>(n, blockalign<T>(n, cellcount), fill);


    }

}