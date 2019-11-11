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
    using static nfunc;

    public static class Span256
    {
        /// <summary>
        /// Reimagines a 256-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<byte> bytes<T>(Span256<T> src)
            where T : unmanaged
                => Span256.load(MemoryMarshal.AsBytes(src.Unblocked));

        /// <summary>
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Span256<T> alloc<T>(int blocks, T? fill = null)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a 1-block span 
        /// </summary>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Span256<T> alloc<T>(T? fill = null)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a 256-bit blocked span of a specified minimum length which may not
        /// partition evently into 256-bit blocks
        /// </summary>
        /// <param name="minlen">The minimum allocation length</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> allocu<T>(int minlen, T? fill = null)
            where T : unmanaged        
        {
            alignment<T>(minlen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return alloc<T>(fullBlocks, fill);
            else
                return alloc<T>(fullBlocks + 1, fill);
        }
        
        /// <summary>
        /// Allocates the minimum amount of memory required to align data of natural length in 256-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> allocu<N,T>(T? fill = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dataLen = nati<N>();
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
        public static Span256<T> allocu<M,N,T>(T? fill = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dataLen = nati<M>() * nati<N>();
            Span256.alignment<T>(dataLen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return alloc<T>(fullBlocks,fill);
            else
                return alloc<T>(fullBlocks + 1,fill);
        }


        /// <summary>
        /// Loads (potentially) unaligned data
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> load<T>(Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(src.Length, out int remainder);
            if(remainder == 0)
                return Span256<T>.LoadAligned(src);
            else
            {
                var dst = alloc<T>(bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }
        
        /// <summary>
        /// Loads (potentially) unaligned data
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> load<T>(T[] src)
            where T : unmanaged
            => load(src.AsSpan());
                
        /// <summary>
        /// Loads an unsized 256-bit blocked span from a sized unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> load<N,T>(Span<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => load<T>(src.Unsized);

        /// <summary>
        /// Loads a 256-bit blocked span from a memory reference
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="minlen">The (256-bit aligned) length of the span </param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> load<T>(ref T src, int minlen)
            where T : unmanaged
        {
            var bz = blockcount<T>(minlen, out int remainder);
            var bl = blocklen<T>();
            var len = remainder == 0 ? bz * bl : (bz + 1) * bl;            
            return Span256<T>.LoadAligned(ref src, len);
        }

        [MethodImpl(Inline)]
        public static Span256<T> load<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(src.Length, out int remainder);
            if(remainder == 0)
                return Span256<T>.LoadAligned(src.Replicate());
            else
            {
                var dst = alloc<T>(bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }
            
        /// <summary>
        /// Computes the minimum number of blocks that can hold data of a specified byte length
        /// </summary>
        /// <param name="srclen">The length of the source data</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static int minblocks<T>(ByteSize srclen)
            where T : unmanaged        
        {
            var bz = blockcount<T>(srclen, out int remainder);
            return remainder == 0 ? bz : bz + 1;
        }

        /// <summary>
        /// Computes the minimum number of 256-bit blocks that can hold a table of data
        /// </summary>
        /// <param name="srclen">The length of the source data</param>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static int minblocks<M,N,T>()
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged        
        {
            var srclen = nati<M>() * nati<N>();
            var bz = blockcount<T>(srclen, out int remainder);
            return remainder == 0 ? bz : bz + 1;
        }

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize cellsize<T>()
            where T : unmanaged        
                => Span256<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize blocksize<T>()
            where T : unmanaged        
                => Span256<T>.BlockSize;

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(int blocks = 1)
            where T : unmanaged        
                => blocks * Span256<T>.BlockLength;

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="length">The length of the cell sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int fullblocks<T>(int length)
            where T : unmanaged  
                => length / blocklen<T>();

        [MethodImpl(Inline)]
        public static int blockcount<T>(int length, out int remainder)
            where T : unmanaged          
            => Math.DivRem(length, blocklen<T>(), out remainder);
        
        /// <summary>
        /// Determines whether data of a specified length can be evenly covered by blocks
        /// </summary>
        /// <param name="datasize">The length, in bytes, of the source data</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(int length)
            where T : unmanaged        
            => Span256<T>.Aligned(length);
        
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
        /// Loads a single blocked span from a parameter array
        /// </summary>
        /// <param name="src">The source parameters</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        static Span256<T> Single<T>(params T[] src)
            where T : unmanaged
                => Span256<T>.Load(src);

        /// <summary>
        /// Calculates the number of bytes consumed by a specified number of cells
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static ByteSize CellBytes<T>(int count)
            where T : unmanaged        
                => count * cellsize<T>();
   }
}