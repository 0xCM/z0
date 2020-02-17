//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;
    using static nfunc;
    using static SpanOps;

    partial class DataBlocks
    {
        /// <summary>
        /// Allocates a specified number of 16-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16)]
        public static Block16<T> alloc<T>(N16 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block16<T>(span<T>(blocks * blocklen<T>(w)));

        /// <summary>
        /// Allocates a specified number of 32-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16 | NumericKind.Width32)]
        public static Block32<T> alloc<T>(N32 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block32<T>(new T[blocks * blocklen<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 64-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Op, NumericClosures(NumericKind.All)]
        public static Block64<T> alloc<T>(N64 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block64<T>(new T[blocks * blocklen<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 128-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Op, NumericClosures(NumericKind.All)]
        public static Block128<T> alloc<T>(N128 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block128<T>(new T[blocks * blocklen<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Op, NumericClosures(NumericKind.All)]
        public static Block256<T> alloc<T>(N256 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block256<T>(new T[blocks * blocklen<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 512-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Op, NumericClosures(NumericKind.All)]
        public static Block512<T> alloc<T>(N512 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block512<T>(new T[blocks * blocklen<T>(w)]);
    }
}