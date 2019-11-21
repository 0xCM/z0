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

    public static class Block128
    {
        /// <summary>
        /// Reimagines a 128-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<byte> bytes<T>(Block128<T> src)
            where T : unmanaged
                => load(MemoryMarshal.AsBytes(src.Unblocked));

        /// <summary>
        /// Allocates a span with a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Block128<T> alloc<T>(int blocks, T? fill = null)
            where T : unmanaged        
                => Block128<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a 1-block span 
        /// </summary>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Block128<T> alloc<T>(T? fill = null)
            where T : unmanaged        
                => Block128<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a 256-bit blocked span of a specified minimum length which may not partition evently into 256-bit blocks
        /// </summary>
        /// <param name="minlen">The minimum allocation length</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static Block128<T> allocu<T>(int minlen, T? fill = null)
            where T : unmanaged        
        {
            alignment<T>(minlen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return alloc<T>(fullBlocks, fill);
            else
                return alloc<T>(fullBlocks + 1, fill);
        }

        /// <summary>
        /// Allocates the minimum amount of memory required to align data of natural length in 128-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> allocu<N,T>(T? fill = null)
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
        public static Block128<T> allocu<M,N,T>(T? fill = null)
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
        public static Block128<T> FromParts<T>(params T[] src)
            where T : unmanaged
                => Block128<T>.Load(src);

        /// <summary>
        /// Loads a blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> load<T>(Span<T> src, int offset = 0)
            where T : unmanaged
                => Block128<T>.Load(src, offset);

        /// <summary>
        /// Loads an unsized 256-bit blocked span from a sized unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> load<N,T>(NatBlock<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => load(src.Unsized);

        /// <summary>
        /// Loads a blocked readonly span from an unblocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> load<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
                => Block128<T>.Load(src, offset);

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int cellsize<T>()
            where T : unmanaged        
                => Block128<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize<T>()
            where T : unmanaged        
                => Block128<T>.BlockSize;


        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(int blocks = 1)
            where T : unmanaged        
                => blocks * Block128<T>.BlockLength;

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="length">The length of the cell sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int fullblocks<T>(int length)
            where T : unmanaged  
                => length / blocklen<T>();

        /// <summary>
        /// Determines whether data of a specified length can be evenly covered by 128-bit primal blocks
        /// </summary>
        /// <param name="datasize">The length, in bytes, of the source data</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(int length)
            where T : unmanaged        
                => Block128<T>.Aligned(length);

        [MethodImpl(Inline)]
        public static int align<T>(int length)
            where T : unmanaged        
        {
            var remainder = length % blocklen<T>();
            if(remainder == 0)
                return length;
            else
                return (length - remainder) + blocklen<T>();
        }                    

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
        public static int blocks<S,T>(Block128<S> lhs, Block128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where T : unmanaged
                where S : unmanaged
                    => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                        : throw CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file,line);

        /// <summary>
        /// Returns the block count of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blocks<S,T>(ConstBlock128<S> lhs, ConstBlock128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where T : unmanaged
                where S : unmanaged
                    => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                        : throw CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file,line);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(ConstBlock128<S> lhs, ConstBlock128<T> rhs, [CallerFilePath] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)        
            where T : unmanaged
            where S : unmanaged
                => lhs.Length == rhs.Length ? lhs.Length 
                    : throw CountMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(Block128<S> lhs, Block128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where S : unmanaged
                where T : unmanaged
                    => lhs.Length == rhs.Length ? lhs.Length 
                        : throw CountMismatch(lhs.Length, rhs.Length, caller, file, line);   
 
         /// <summary>
        /// Returns a reference to the first element of a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<T>(in Block128<T> src)
            where T : unmanaged
                =>  ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a readonly reference to the first element of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref readonly T head<T>(in ConstBlock128<T> src)
            where T : unmanaged
                =>  ref MemoryMarshal.GetReference<T>(src);

    }
}