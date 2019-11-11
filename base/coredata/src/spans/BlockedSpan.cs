//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;    
    using System.Diagnostics;
        
    using static zfunc;

    /// <summary>
    /// Defines api surface for blocked span allocation/manipulation
    /// </summary>
    public static class BlockedSpan
    {
        /// <summary>
        /// Allocates a 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> alloc<T>(N128 n)
            where T : unmanaged        
                => Span128<T>.AllocBlocks(1);

        /// <summary>
        /// Allocates a 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> alloc<T>(N256 n)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(1);

        /// <summary>
        /// Allocates a 1-block 128-bit span 
        /// </summary>
        /// <param name="fill">A value used to initialize each cell</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> alloc<T>(N128 n, T fill)
            where T : unmanaged        
                => Span128<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a 1-block 256-bit span 
        /// </summary>
        /// <param name="fill">A value used to initialize each cell</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> alloc<T>(N256 n, T fill)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> alloc<T>(N128 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Span128<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> alloc<T>(N256 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Transfers the source source directly to a blocked span, raising an error if the source span is not properly blocked
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> transfer<T>(N128 n, Span<T> src)
            where T : unmanaged        
                => Span128<T>.Transfer(src);

        /// <summary>
        /// Transfers the source source directly to a blocked span, raising an error if the source span is not properly blocked
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> transfer<T>(N256 n, Span<T> src)
            where T : unmanaged        
                => Span256<T>.Transfer(src);

        /// <summary>
        /// Loads (potentially) unaligned data
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(NotInline)]
        public static Span128<T> load<T>(N128 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return Span128<T>.TransferUnsafe(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads (potentially) unaligned data
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(NotInline)]
        public static Span256<T> load<T>(N256 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return Span256<T>.TransferUnsafe(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads a 128-bit blocked span from a natural span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> load<N,T>(N128 n, Span<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Span128.load(src);

        /// <summary>
        /// Loads a 256-bit blocked span from a natural span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> load<N,T>(N256 n, Span<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Span256.load(src);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N128 n, int blocks = 1)
            where T : unmanaged        
                => blocks * Span128<T>.BlockLength;

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N256 n,int blocks = 1)
            where T : unmanaged        
                => blocks * Span256<T>.BlockLength;

        [MethodImpl(Inline)]
        static int blockcount<T>(N128 n, int length, out int remainder)
            where T : unmanaged          
                => Math.DivRem(length, blocklen<T>(n), out remainder);

        [MethodImpl(Inline)]
        static int blockcount<T>(N256 n, int length, out int remainder)
            where T : unmanaged          
                => Math.DivRem(length, blocklen<T>(n), out remainder);
    }
}