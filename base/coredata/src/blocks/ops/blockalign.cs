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
        /// Computes the minimum number of 64-bit blocks required to cover a specified number of cells
        /// </summary>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>If a constant/literal value is supplied for the cellcount parameter, the jitter will 
        /// resolve the computation to a constant an no runtime computations will occur</remarks>
        [MethodImpl(Inline)]
        public static int blockalign<T>(N32 n, int cellcount)
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
        public static int blockalign<T>(N64 n, int cellcount)
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
        public static int blockalign<T>(N128 n, int cellcount)
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
        public static int blockalign<T>(N256 n, int cellcount)
            where T : unmanaged        
        {
            var blockcount = cellcount / blocklen<T>(n);
            return cellcount % blocklen<T>(n) == 0 ? blockcount : blockcount + 1;
        } 
    }
}