//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static Root;

    partial class Blocks
    {
        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int cellblocks<T>(N8 n, int blocks)
            where T : unmanaged        
                => blocks * length<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int cellblocks<T>(N16 n, int blocks)
            where T : unmanaged        
                => blocks * length<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int cellblocks<T>(N32 n, int blocks)
            where T : unmanaged        
                => blocks * length<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int cellblocks<T>(N64 n, int blocks)
            where T : unmanaged        
                => blocks * length<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int cellblocks<T>(N128 n, int blocks)
            where T : unmanaged        
                => blocks * length<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int cellblocks<T>(N256 n, int blocks)
            where T : unmanaged        
                => blocks * length<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int cellblocks<T>(N512 n, int blocks)
            where T : unmanaged        
                => blocks * length<T>(n);
    }
}