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

    public static class Block64
    {
        static N64 N => default;

        /// <summary>
        /// Allocates a span with a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Block64<T> alloc<T>(int blocks, T? fill = null)
            where T : unmanaged        
                => Block64<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates the minimum amount of memory required to align data of natural length in 64-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> allocu<N,T>(T? fill = null)
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
        /// Loads a blocked readonly span from an unblocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> load<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
                => Block64<T>.Load(src, offset);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(int blocks = 1)
            where T : unmanaged        
                => blocks * Block64<T>.BlockLength;

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
            blocklen = MemBlocks.blocklen<T>(N);
            fullBlocks = srcLen / blocklen;
            remainder = srcLen % MemBlocks.blocklen<T>(N);
        } 
 
    }
}