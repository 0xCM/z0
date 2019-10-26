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

    public static class BlockedSpan
    {
        /// <summary>
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Span128<T> AllocBlocks<T>(N128 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Span128<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a 1-block span 
        /// </summary>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Span128<T> AllocBlock<T>(N128 n)
            where T : unmanaged        
                => Span128<T>.AllocBlocks(1);

        [MethodImpl(NotInline)]
        public static Span128<T> AllocBlock<T>(N128 n, T fill)
            where T : unmanaged        
                => Span128<T>.AllocBlocks(1, fill);

        [MethodImpl(NotInline)]
        public static Span256<T> AllocBlock<T>(N256 n, T fill)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Span256<T> AllocBlocks<T>(N256 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a 1-block span 
        /// </summary>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Span256<T> AllocBlock<T>(N256 n)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(1);

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize CellSize<T>(N128 n)
            where T : unmanaged        
                => Span128<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize BlockSize<T>(N128 n)
            where T : unmanaged        
                => Span128<T>.BlockSize;

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int BlockLength<T>(N128 n,int blocks = 1)
            where T : unmanaged        
                => blocks * Span128<T>.BlockLength;

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="length">The length of the cell sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int WholeBlocks<T>(N128 n, int length)
            where T : unmanaged  
                => length / BlockLength<T>(n);

        [MethodImpl(Inline)]
        public static int BlockCount<T>(N128 n, int length, out int remainder)
            where T : unmanaged          
                => Math.DivRem(length, BlockLength<T>(n), out remainder);

        /// <summary>
        /// Loads (potentially) unaligned data
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(NotInline)]
        public static Span256<T> Load<T>(N256 n, Span<T> src)
            where T : unmanaged
        {
            var bz = BlockCount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return Span256<T>.LoadAligned(src);
            else
            {
                var dst = AllocBlocks<T>(n, bz + 1);
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
        public static Span128<T> Load<T>(N128 n, Span<T> src)
            where T : unmanaged
        {
            var bz = BlockCount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return Span128<T>.Transfer(src);
            else
            {
                var dst = AllocBlocks<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int BlockLength<T>(N256 n,int blocks = 1)
            where T : unmanaged        
                => blocks * Span256<T>.BlockLength;

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="length">The length of the cell sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int WholeBlocks<T>(N256 n, int length)
            where T : unmanaged  
                => length / BlockLength<T>(n);

        [MethodImpl(Inline)]
        public static int BlockCount<T>(N256 n, int length, out int remainder)
            where T : unmanaged          
                => Math.DivRem(length, BlockLength<T>(n), out remainder);

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize CellSize<T>(N256 n)
            where T : unmanaged        
                => Span256<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize BlockSize<T>(N256 n)
            where T : unmanaged        
                => Span256<T>.BlockSize;

    }


}