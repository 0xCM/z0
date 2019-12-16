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
    using static nfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Allocates a specified number of 16-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Block16<T> alloc<T>(N16 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block16<T>(new T[blocks * blocklen<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 32-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Block32<T> alloc<T>(N32 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block32<T>(new T[blocks * blocklen<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 64-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Block64<T> alloc<T>(N64 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block64<T>(new T[blocks * blocklen<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 128-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Block128<T> alloc<T>(N128 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block128<T>(new T[blocks * blocklen<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Block256<T> alloc<T>(N256 w, int blocks, T t = default)
            where T : unmanaged        
                => new Block256<T>(new T[blocks * blocklen<T>(w)]);

        /// <summary>
        /// Allocates a block of natural cell count
        /// </summary>
        /// <param name="n">The total number of cells in the block</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="N"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static NatBlock<N,T> natalloc<N,T>(N n = default, T t = default) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N,T>(new T[natval<N>()]);
    }
}