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
    using System.Diagnostics;
        
    using static zfunc;    
    using static Span64;

    public static class Span64
    {
        /// <summary>
        /// Allocates a span with a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Span64<T> alloc<T>(int blocks, T? fill = null)
            where T : unmanaged        
                => Span64<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a 256-bit blocked span of a specified minimum length which may not partition evently into 256-bit blocks
        /// </summary>
        /// <param name="minlen">The minimum allocation length</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Span64<T> allocu<T>(int minlen, T? fill = null)
            where T : unmanaged        
        {
            alignment<T>(minlen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return alloc<T>(fullBlocks, fill);
            else
                return alloc<T>(fullBlocks + 1, fill);
        }

        /// <summary>
        /// Allocates the minimum amount of memory required to align data of natural length in 64-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> allocu<N,T>(T? fill = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dataLen = nfunc.nati<N>();
            alignment<T>(dataLen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return alloc<T>(fullBlocks,fill);
            else
                return alloc<T>(fullBlocks + 1,fill);
        }

        /// <summary>
        /// Allocates the minimum amount of memory required to align matrix/tabular data in 256-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> allocu<M,N,T>(T? fill = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dataLen = nfunc.nati<M>() * nfunc.nati<N>();
            alignment<T>(dataLen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return alloc<T>(fullBlocks, fill);
            else
                return alloc<T>(fullBlocks + 1,fill);
        }

        /// <summary>
        /// Loads a single blocked span from a parameter array
        /// </summary>
        /// <param name="src">The source parameters</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> FromParts<T>(params T[] src)
            where T : unmanaged
                => Span64<T>.Load(src);

        /// <summary>
        /// Loads a blocked readonly span from an unblocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> load<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
                => Span64<T>.Load(src, offset);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(int blocks = 1)
            where T : unmanaged        
                => blocks * Span64<T>.BlockLength;

        /// <summary>
        /// Calculates alignment attributes predicated on a source length and element type
        /// </summary>
        /// <param name="srcLen">The source length</param>
        /// <param name="blocklen">The number of cells in a block</param>
        /// <param name="fullBlocks">The number of whole blocks into which the source length can be partitioned</param>
        /// <param name="remainder">The number of cells that cannot fit into a sequence of full blocks</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void alignment<T>(int srcLen, out int blocklen, out int fullBlocks, out int remainder)
            where T : unmanaged        
        {
            blocklen = blocklen<T>();
            fullBlocks = srcLen / blocklen;
            remainder = srcLen % blocklen<T>();
        } 

        /// <summary>
        /// Returns the block count of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blocks<S,T>(in Span64<S> lhs, in Span64<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : badsize<int>(lhs.BlockCount,rhs.BlockCount);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in Span64<S> lhs, in Span64<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.Length == rhs.Length ? lhs.Length : badsize<int>(lhs.Length,rhs.Length);
 
    }
}