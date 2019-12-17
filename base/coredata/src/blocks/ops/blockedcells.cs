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
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockedcells<T>(N8 n, int blocks)
            where T : unmanaged        
                => blocks * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockedcells<T>(N16 n, int blocks)
            where T : unmanaged        
                => blocks * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockedcells<T>(N32 n, int blocks)
            where T : unmanaged        
                => blocks * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockedcells<T>(N64 n, int blocks)
            where T : unmanaged        
                => blocks * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockedcells<T>(N128 n, int blocks)
            where T : unmanaged        
                => blocks * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockedcells<T>(N256 n, int blocks)
            where T : unmanaged        
                => blocks * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockedcells<T>(N512 n, int blocks)
            where T : unmanaged        
                => blocks * blocklen<T>(n);


    }

}