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
        /// Allocates a specified number of 8-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric16u)]
        public static Block8<T> alloc<T>(W8 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block8<T>(new T[blocks * length<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 16-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric16u)]
        public static Block16<T> alloc<T>(W16 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block16<T>(new T[blocks * length<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 32-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block32<T> alloc<T>(W32 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block32<T>(new T[blocks * length<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 64-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block64<T> alloc<T>(W64 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block64<T>(new T[blocks * length<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 128-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block128<T> alloc<T>(W128 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block128<T>(new T[blocks * length<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block256<T> alloc<T>(W256 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block256<T>(new T[blocks * length<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 512-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(Numeric32u)]
        public static Block512<T> alloc<T>(W512 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block512<T>(new T[blocks * length<T>(w)]);
    }
}