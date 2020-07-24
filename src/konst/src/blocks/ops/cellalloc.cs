//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Konst;        

    partial struct Blocks
    {
        /// <summary>
        /// Allocates a sequence of 8-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt8k)]
        public static Block8<T> cellalloc<T>(W8 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 16-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt16k)]
        public static Block16<T> cellalloc<T>(W16 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 32-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block32<T> cellalloc<T>(W32 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 64-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block64<T> cellalloc<T>(W64 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 128-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block128<T> cellalloc<T>(W128 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 256-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block256<T> cellalloc<T>(W256 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 512-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block512<T> cellalloc<T>(W512 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));
    }
}