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
        /// Computes the minimum number of 8-bit blocks required to cover a specified number of cells
        /// </summary>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>If a constant/literal value is supplied for the cellcount parameter, the jitter will 
        /// resolve the computation to a constant an no runtime computations will occur</remarks>
        [MethodImpl(Inline)]
        public static int minblocks<T>(N8 n, int cellcount)
            where T : unmanaged        
        {
            var blockcount = cellcount / blocklen<T>(n);
            return cellcount % blocklen<T>(n) == 0 ? blockcount : blockcount + 1;
        } 

        /// <summary>
        /// Computes the minimum number of 32-bit blocks required to cover a specified number of cells
        /// </summary>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>If a constant/literal value is supplied for the cellcount parameter, the jitter will 
        /// resolve the computation to a constant an no runtime computations will occur</remarks>
        [MethodImpl(Inline)]
        public static int minblocks<T>(N16 n, int cellcount)
            where T : unmanaged        
        {
            var blockcount = cellcount / blocklen<T>(n);
            return cellcount % blocklen<T>(n) == 0 ? blockcount : blockcount + 1;
        } 

        /// <summary>
        /// Computes the minimum number of 32-bit blocks required to cover a specified number of cells
        /// </summary>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>If a constant/literal value is supplied for the cellcount parameter, the jitter will 
        /// resolve the computation to a constant an no runtime computations will occur</remarks>
        [MethodImpl(Inline)]
        public static int minblocks<T>(N32 n, int cellcount)
            where T : unmanaged        
        {
            var blockcount = cellcount / blocklen<T>(n);
            return cellcount % blocklen<T>(n) == 0 ? blockcount : blockcount + 1;
        } 

        /// <summary>
        /// Computes the minimum number of 64-bit blocks required to cover a specified number of cells
        /// </summary>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>If a constant/literal value is supplied for the cellcount parameter, the jitter will 
        /// resolve the computation to a constant an no runtime computations will occur</remarks>
        [MethodImpl(Inline)]
        public static int minblocks<T>(N64 n, int cellcount)
            where T : unmanaged        
        {
            var blockcount = cellcount / blocklen<T>(n);
            return cellcount % blocklen<T>(n) == 0 ? blockcount : blockcount + 1;
        } 

        /// <summary>
        /// Computes the minimum number of 128-bit blocks required to cover a specified number of cells
        /// </summary>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>If a constant/literal value is supplied for the cellcount parameter, the jitter will 
        /// resolve the computation to a constant an no runtime computations will occur</remarks>
        [MethodImpl(Inline)]
        public static int minblocks<T>(N128 n, int cellcount)
            where T : unmanaged        
        {
            var blockcount = cellcount / blocklen<T>(n);
            return cellcount % blocklen<T>(n) == 0 ? blockcount : blockcount + 1;
        } 

        /// <summary>
        /// Computes the minimum number of 256-bit blocks required to cover a specified number of cells
        /// </summary>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>If a constant/literal value is supplied for the cellcount parameter, the jitter will 
        /// resolve the computation to a constant an no runtime computations will occur</remarks>
        [MethodImpl(Inline)]
        public static int minblocks<T>(N256 n, int cellcount)
            where T : unmanaged        
        {
            var blockcount = cellcount / blocklen<T>(n);
            return cellcount % blocklen<T>(n) == 0 ? blockcount : blockcount + 1;
        } 

        /// <summary>
        /// Computes the minimum numbet of W-blocks over T-cells required to cover a grid of natural dimensions MxN
        /// </summary>
        /// <param name="w">The block width represntative</param>
        /// <param name="m">The col count representative</param>
        /// <param name="n">The row count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="W">The block type</typeparam>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int minblocks<W,M,N,T>(W w = default, M m = default, N n = default, T t = default)
            where W : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged        
        {            
            var cellblocks = blocklen<W,T>();
            var blockcount = cellblocks/cellsize<T>();
            return blockcount + cellblocks % cellsize<T>() == 0 ? 0 : 1;
        }

    }
}