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
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="n">The block length selector</param>
        /// <param name="cellcount">The number of cells to partition</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int wholeblocks<T>(N8 n, int cellcount)
            where T : unmanaged  
                => cellcount / blocklen<T>(n);

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="n">The block length selector</param>
        /// <param name="cellcount">The number of cells to partition</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int wholeblocks<T>(N16 n, int cellcount)
            where T : unmanaged  
                => cellcount / blocklen<T>(n);

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="n">The block length selector</param>
        /// <param name="cellcount">The number of cells to partition</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int wholeblocks<T>(N32 n, int cellcount)
            where T : unmanaged  
                => cellcount / blocklen<T>(n);

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="n">The block length selector</param>
        /// <param name="cellcount">The number of cells to partition</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int wholeblocks<T>(N64 n, int cellcount)
            where T : unmanaged  
                => cellcount / blocklen<T>(n);

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="n">The block length selector</param>
        /// <param name="cellcount">The number of cells to partition</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int wholeblocks<T>(N128 n, int cellcount)
            where T : unmanaged  
                => cellcount / blocklen<T>(n);

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="n">The block length selector</param>
        /// <param name="cellcount">The number of cells to partition</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int wholeblocks<T>(N256 n, int cellcount)
            where T : unmanaged  
                => cellcount / blocklen<T>(n);

    }

}