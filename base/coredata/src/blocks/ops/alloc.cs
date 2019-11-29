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
        /// Allocates a specified number of 32-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> alloc<T>(N32 n, int blocks)
            where T : unmanaged        
        {
            Span<T> data = new T[blocks * blocklen<T>(n)];
            return new Block32<T>(data);
        }

        /// <summary>
        /// Allocates 1 64-bit block
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> alloc<T>(N32 n)
            where T : unmanaged        
                => alloc<T>(n,1);

        /// <summary>
        /// Allocates a specified number of 64-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> alloc<T>(N64 n, int blocks)
            where T : unmanaged        
        {
            Span<T> data = new T[blocks * blocklen<T>(n)];
            return new Block64<T>(data);
        }

        /// <summary>
        /// Allocates 1 64-bit block
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> alloc<T>(N64 n)
            where T : unmanaged        
                => alloc<T>(n,1);

        /// <summary>
        /// Allocates a 128-bit 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> alloc<T>(N128 n)
            where T : unmanaged        
        {
            Span<T> dst = new T[1 * blocklen<T>(n)];
            return new Block128<T>(dst);
        }

        /// <summary>
        /// Allocates a specified number of 128-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> alloc<T>(N128 n, int blocks)
            where T : unmanaged        
        {
            Span<T> data = new T[blocks * blocklen<T>(n)];
            return new Block128<T>(data);
        }

        /// <summary>
        /// Allocates a 256-bit 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> alloc<T>(N256 n)
            where T : unmanaged        
                => alloc<T>(n,1);

        /// <summary>
        /// Allocates a specified number of 256-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> alloc<T>(N256 n, int blocks)
            where T : unmanaged        
        {
            Span<T> data = new T[blocks * blocklen<T>(n)];
            return new Block256<T>(data);
        }

        /// <summary>
        /// Allocates the minimum amount of memory required to align matrix/tabular data in 256-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> alloc<M,N,T>(N256 n)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => alloc<T>(n,blockalign<T>(n, NatMath.mul<M,N>()));

        [MethodImpl(Inline)]
        public static Block256<T> alloc<N,T>(N256 n)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => alloc<T>(n,blockalign<T>(n, nati<N>()));

    }

}