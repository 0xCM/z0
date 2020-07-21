//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;        

    partial struct Cells
    {
        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int cellblocks<T>(W8 n, int blocks)
            where T : unmanaged        
                => blocks * z.blocklength<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int cellblocks<T>(W16 n, int blocks)
            where T : unmanaged        
                => blocks * z.blocklength<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int cellblocks<T>(W32 n, int blocks)
            where T : unmanaged        
                => blocks * z.blocklength<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int cellblocks<T>(W64 n, int blocks)
            where T : unmanaged        
                => blocks * z.blocklength<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int cellblocks<T>(W128 n, int blocks)
            where T : unmanaged        
                => blocks * z.blocklength<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int cellblocks<T>(W256 n, int blocks)
            where T : unmanaged        
                => blocks * z.blocklength<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int cellblocks<T>(W512 n, int blocks)
            where T : unmanaged        
                => blocks * z.blocklength<T>(n);
    }
}