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
        /// Allocates a 32-bit block container to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> cellalloc<T>(N16 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, minblocks<T>(n, cellcount));

        /// <summary>
        /// Allocates a 32-bit block container to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> cellalloc<T>(N32 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, minblocks<T>(n, cellcount));

        /// <summary>
        /// Allocates a 32-bit block container to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> cellalloc<T>(N64 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, minblocks<T>(n, cellcount));

        /// <summary>
        /// Allocates a 32-bit block container to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> cellalloc<T>(N128 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, minblocks<T>(n, cellcount));

        /// <summary>
        /// Allocates a 32-bit block container to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> cellalloc<T>(N256 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, minblocks<T>(n, cellcount));

        /// <summary>
        /// Allocates a 32-bit block container to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> cellalloc<T>(N512 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, minblocks<T>(n, cellcount));

    }
}