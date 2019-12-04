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
        /// Computes the number of blocks required to cover a specified number of bits
        /// </summary>
        /// <param name="srcbits">The source bit count</param>
        /// <param name="blockwidth">The block width in bits</param>
        [MethodImpl(Inline)]
        public static int blockcount(int srcbits, int blockwidth)
        {
            var a = srcbits / blockwidth;
            return a + (srcbits % a == 0 ? 0 : 1);
            // var a = blockwidth*blockwidth;
            // var whole = srcbits/a;
            // return whole + (srcbits % a == 0 ? 0 : 1);
        }

        /// <summary>
        /// Computes the number of blocks required to cover a specified number of bits
        /// </summary>
        /// <param name="dstblockbits">The target block size in bits</param>
        [MethodImpl(Inline)]
        public static int blockcount<T>(int srcbits)
            where T : unmanaged
                => blockcount(srcbits, Unsafe.SizeOf<T>()*8);

        /// <summary>
        /// Computes the number of cells that comprise a single 8-bit block
        /// </summary>
        /// <param name="n">The bit width representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N8 n)
            where T : unmanaged
                => Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 16-bit block
        /// </summary>
        /// <param name="n">The bit width representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N16 n)
            where T : unmanaged
                => 2/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 32-bit block
        /// </summary>
        /// <param name="n">The bit width representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N32 n)
            where T : unmanaged
                => 4/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a single 64-bit block
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N64 n)
            where T : unmanaged
                => 8/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a single 128-bit block
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N128 n)
            where T : unmanaged
                => 16/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a 256-bit block
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N256 n)
            where T : unmanaged
                => 32/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of T-cells that comprise an N-block
        /// </summary>
        /// <param name="n">The bit width representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatMath.div(n,N8.Rep)/Unsafe.SizeOf<T>();

    }

}