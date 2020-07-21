//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Konst;        

    using static z;

    partial struct Cells
    {
        /// <summary>
        /// Allocates a single 8-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(Numeric8k)]
        public static Block8<T> alloc<T>(W8 w)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 16-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(Numeric8x16k)]
        public static Block16<T> alloc<T>(W16 w)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 32-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(Numeric8x16x32k)]
        public static Block32<T> alloc<T>(W32 w)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 64-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UnsignedInts)]
        public static Block64<T> alloc<T>(W64 w)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 128-bit block over cells of parametric kind
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UnsignedInts)]
        public static Block128<T> alloc<T>(W128 w)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 256-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UnsignedInts)]
        public static Block256<T> alloc<T>(W256 w)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 512-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(UnsignedInts)]
        public static Block512<T> alloc<T>(W512 w)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a specified number of 8-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt8k)]
        public static Block8<T> alloc<T>(W8 w, ulong count, T t = default)
            where T : unmanaged        
                => new Block8<T>(new T[count * (ulong)blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 16-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt8x16k)]
        public static Block16<T> alloc<T>(W16 w, ulong count, T t = default)
            where T : unmanaged        
                => new Block16<T>(new T[count * (ulong)blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 32-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt8x16x32k)]
        public static Block32<T> alloc<T>(W32 w, ulong count, T t = default)
            where T : unmanaged        
                => new Block32<T>(new T[count * (ulong)blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 64-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UnsignedInts)]
        public static Block64<T> alloc<T>(W64 w, ulong count, T t = default)
            where T : unmanaged        
                => new Block64<T>(new T[count * (ulong)blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 128-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UnsignedInts)]
        public static Block128<T> alloc<T>(W128 w, ulong count, T t = default)
            where T : unmanaged        
                => new Block128<T>(new T[count * (ulong)blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UnsignedInts)]
        public static Block256<T> alloc<T>(W256 w, ulong count, T t = default)
            where T : unmanaged        
                => new Block256<T>(new T[count * (ulong)blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 512-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UnsignedInts)]
        public static Block512<T> alloc<T>(W512 w, ulong blocks, T t = default)
            where T : unmanaged        
                => new Block512<T>(new T[blocks * (ulong)blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 8-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt8k)]
        public static Block8<T> alloc<T>(W8 w, long count, T t = default)
            where T : unmanaged        
                => new Block8<T>(new T[count * blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 16-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt8x16k)]
        public static Block16<T> alloc<T>(W16 w, long count, T t = default)
            where T : unmanaged        
                => new Block16<T>(new T[count * blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 32-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt8x16x32k)]
        public static Block32<T> alloc<T>(W32 w, long count, T t = default)
            where T : unmanaged        
                => new Block32<T>(new T[count * blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 64-bit blocks, filled with an optional pattern
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UnsignedInts)]
        public static Block64<T> alloc<T>(W64 w, long count, T t = default)
            where T : unmanaged        
                => new Block64<T>(new T[count * blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 128-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="count">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UnsignedInts)]
        public static Block128<T> alloc<T>(W128 w, long count, T t = default)
            where T : unmanaged        
                => new Block128<T>(new T[count * blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 256-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UnsignedInts)]
        public static Block256<T> alloc<T>(W256 w, long blocks, T t = default)
            where T : unmanaged        
                => new Block256<T>(new T[blocks * blocklength<T>(w)]);

        /// <summary>
        /// Allocates a specified number of 512-bit blocks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="blocks">The block allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UnsignedInts)]
        public static Block512<T> alloc<T>(W512 w, long blocks, T t = default)
            where T : unmanaged        
                => new Block512<T>(new T[blocks * blocklength<T>(w)]);


        /// <summary>
        /// Allocates a sequence of 8-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt8k)]
        public static Block8<T> alloc<T>(W8 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 16-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt16k)]
        public static Block16<T> alloc<T>(W16 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 32-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block32<T> alloc<T>(W32 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 64-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block64<T> alloc<T>(W64 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 128-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block128<T> alloc<T>(W128 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 256-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block256<T> alloc<T>(W256 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));

        /// <summary>
        /// Allocates a sequence of 512-bit blocks sufficient to cover a specified number of cells
        /// </summary>
        /// <param name="n">The block width selector</param>
        /// <param name="cellcount">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Alloc, Closures(UInt32k)]
        public static Block512<T> alloc<T>(W512 n, ulong cellcount)
            where T : unmanaged        
                => alloc<T>(n, cellcover<T>(n, cellcount));
    }
}