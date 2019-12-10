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
        [MethodImpl(NotInline)]   
        public static NatBlock<N,T> natalloc<N,T>(N n = default, T t = default) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<T> data = new T[natval<N>()];
            return new NatBlock<N,T>(data);
        }

        /// <summary>
        /// Loads a natural block from blocked storage
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="n">The length representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static NatBlock<N,T> natload<N,T>(in Block256<T> src, N n = default)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N, T>(src.data);

        /// <summary>
        /// Loads a natural block from a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="n">The length representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static NatBlock<N,T> natload<N,T>(ref T src, N n = default)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {                
            var data = MemoryMarshal.CreateSpan(ref src, natval<N>());
            return new NatBlock<N,T>(data);
        }

        [MethodImpl(Inline)]   
        public static NatBlock<N,T> natparts<N,T>(N n, params T[] cells) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<T> src = cells;
            return checkedload(src,n);
        }

        /// <summary>
        /// Allocates a specified number of 16-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> alloc<T>(N16 n, int blocks = 1)
            where T : unmanaged        
        {
            Span<T> data = new T[blocks * blocklen<T>(n)];
            return load(data,n);
        }

        /// <summary>
        /// Allocates a specified number of 32-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> alloc<T>(N32 n, int blocks = 1)
            where T : unmanaged        
        {
            Span<T> data = new T[blocks * blocklen<T>(n)];
            return load(data,n);
        }

        /// <summary>
        /// Allocates a specified number of 64-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> alloc<T>(N64 n, int blocks = 1)
            where T : unmanaged        
        {
            Span<T> data = new T[blocks * blocklen<T>(n)];
            return load(data,n);
        }

        /// <summary>
        /// Allocates a specified number of 128-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> alloc<T>(N128 n, int blocks = 1)
            where T : unmanaged        
        {
            Span<T> data = new T[blocks * blocklen<T>(n)];
            return load(data,n);
        }

        /// <summary>
        /// Allocates a specified number of 256-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> alloc<T>(N256 n, int blocks = 1)
            where T : unmanaged        
        {
            Span<T> data = new T[blocks * blocklen<T>(n)];
            return load(data,n);
        }
    }
}