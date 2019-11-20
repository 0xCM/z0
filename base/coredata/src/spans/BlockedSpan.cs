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

    /// <summary>
    /// Defines api surface for blocked span allocation/manipulation
    /// </summary>
    public static class BlockedSpan
    {
        /// <summary>
        /// Allocates a 64-bit 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> alloc<T>(N64 n)
            where T : unmanaged        
                => Span64<T>.AllocBlocks(1);

        /// <summary>
        /// Allocates a 128-bit 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> alloc<T>(N128 n)
            where T : unmanaged        
                => Span128<T>.AllocBlocks(1);

        /// <summary>
        /// Allocates a 256-bit 1-block span 
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> alloc<T>(N256 n)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(1);

        /// <summary>
        /// Allocates a 64-bit 1-block span filled with a specified pattern
        /// </summary>
        /// <param name="fill">A value used to initialize each cell</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> alloc<T>(N64 n, T fill)
            where T : unmanaged        
                => Span64<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a 128-bit 1-block span filled with a specified pattern
        /// </summary>
        /// <param name="fill">A value used to initialize each cell</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> alloc<T>(N128 n, T fill)
            where T : unmanaged        
                => Span128<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a 256-bit 1-block span filled with a specified pattern
        /// </summary>
        /// <param name="fill">A value used to initialize each cell</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> alloc<T>(N256 n, T fill)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(1, fill);

        /// <summary>
        /// Allocates a specified number of 64-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> alloc<T>(N64 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Span64<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a specified number of 128-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> alloc<T>(N128 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Span128<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Allocates a specified number of 256-bit blocks, flashed with an optional fill pattern
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <param name="fill">An optional value that, if specified, is used to initialize the cell values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> alloc<T>(N256 n, int blocks, T? fill = null)
            where T : unmanaged        
                => Span256<T>.AllocBlocks(blocks, fill);

        /// <summary>
        /// Covers an unblocked span with 128-bit blocks, raising an error if the source span bit length is not evenly divisible by 128
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> transfer<T>(N64 n, Span<T> src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n,src.Length);
            return new Span64<T>(src);
        }        

        /// <summary>
        /// Covers an unblocked span with 128-bit blocks, raising an error if the source span bit length is not evenly divisible by 128
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> transfer<T>(N128 n, Span<T> src)
            where T : unmanaged        
                => Span128<T>.Transfer(src);

        /// <summary>
        /// Covers an unblocked span with 256-bit blocks, raising an error if the source span bit length is not evenly divisible by 256
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> transfer<T>(N256 n, Span<T> src)
            where T : unmanaged        
                => Span256<T>.Transfer(src);

        /// <summary>
        /// Creates 64-bit blocked span from a parameter array and raises an error if the data source is not block-aligned
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> load<T>(N64 n, params T[] src)
            where T : unmanaged        
                => Span64<T>.Load(src);

        /// <summary>
        /// Loads an unsized 64-bit blocked span from a natural unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<T> load<N,T>(N64 n, in Span<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat<N>, INatDivisible<N,N64>
                => load(n, src.Unsized);

        [MethodImpl(Inline)]
        public static Span64<T> load<T>(N64 n, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      

            return new Span64<T>(offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static unsafe Span64<T> load<T>(N64 n, T* src, int length)
            where T : unmanaged
        {
            if(!aligned<T>(n,length))
                badsize(n,length);

            return new Span64<T>(src,length);
        }

        /// <summary>
        /// Loads 128-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        [MethodImpl(NotInline)]
        public static Span64<T> loadu<T>(N64 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return Span64<T>.TransferUnsafe(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Creates 128-bit blocked span from a parameter array and raises an error if the
        /// data source is improperly blocked
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> load<T>(N128 n, params T[] src)
            where T : unmanaged        
                => Span128<T>.Load(src);

        /// <summary>
        /// Creates 256-bit blocked span from a parameter array and raises an error if the
        /// data source is improperly blocked
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> load<T>(N256 n, params T[] src)
            where T : unmanaged        
                => Span256<T>.Load(src);

        /// <summary>
        /// Loads 128-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        [MethodImpl(NotInline)]
        public static Span128<T> loadu<T>(N128 n, Span<T> src)
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
        /// Loads 256-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouranged unless absolutely necessary</remarks>
        [MethodImpl(NotInline)]
        public static Span256<T> loadu<T>(N256 n, Span<T> src)
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


        [MethodImpl(Inline)]
        public static unsafe Span128<T> load<T>(N128 n, void* src, int length)
            where T : unmanaged
        {
            if(!aligned<T>(n,length))
                badsize(n,length);
            
            return new Span128<T>(src,length);
        }

        [MethodImpl(Inline)]
        public static unsafe Span256<T> load<T>(N256 n, void* src, int length)
            where T : unmanaged
        {
            if(!aligned<T>(n,length))
                badsize(n,length);

            return new Span256<T>(src,length);
        }

        /// <summary>
        /// Computes the number of elements that comprise a single 64-bit block
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N64 n)
            where T : unmanaged
                => 8/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a single 128-bit block
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N128 n)
            where T : unmanaged
                => 16/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a 256-bit block
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N256 n)
            where T : unmanaged
                => 32/Unsafe.SizeOf<T>();

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N64 n, int blocks = 1)
            where T : unmanaged        
                => blocks * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N128 n, int blocks = 1)
            where T : unmanaged        
                => blocks * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N256 n,int blocks = 1)
            where T : unmanaged        
                => blocks * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize<T>(N64 n)
            where T : unmanaged        
                => Unsafe.SizeOf<T>() * blocklen<T>(n);

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="cells">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int fullblocks<T>(N64 n, int cells)
            where T : unmanaged  
                => cells / blocklen<T>(n);

        /// <summary>
        /// Reimagines a 64-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span64<byte> bytes<T>(in Span64<T> src, N64 n = default)
            where T : unmanaged
                => BlockedSpan.load(n,MemoryMarshal.AsBytes(src.Unblocked));

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 64-bit primal blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(N64 n, int count)
            where T : unmanaged        
                => count % blocklen<T>(n) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 128-bit primal blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(N128 n, int count)
            where T : unmanaged        
                => count % blocklen<T>(n) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 256-bit primal blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(N256 n, int count)
            where T : unmanaged        
                => count % blocklen<T>(n) == 0;

        
        [MethodImpl(Inline)]
        public static int align<T>(N64 n, int count)
            where T : unmanaged        
        {
            var remainder = count % blocklen<T>(n);
            if(remainder == 0)
                return count;
            else
                return (count - remainder) + blocklen<T>(n);
        }                    

        [MethodImpl(Inline)]
        static int blockcount<T>(N64 n, int length, out int remainder)
            where T : unmanaged          
                => Math.DivRem(length, blocklen<T>(n), out remainder);

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