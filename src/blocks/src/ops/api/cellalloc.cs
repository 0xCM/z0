//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Seed;        

    partial class Blocks
    {
        /// <summary>
        /// Allocates a sequence of 8-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric8u)]
        public static Block8<T> cellalloc<T>(W8 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 16-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric16u)]
        public static Block16<T> cellalloc<T>(W16 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 32-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block32<T> cellalloc<T>(W32 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 64-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block64<T> cellalloc<T>(W64 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 128-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block128<T> cellalloc<T>(W128 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 256-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block256<T> cellalloc<T>(W256 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 512-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block512<T> cellalloc<T>(W512 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));
    }
}