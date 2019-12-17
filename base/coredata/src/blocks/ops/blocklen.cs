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
        /// Computes the number of cells that comprise a single 8-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N8 w)
            where T : unmanaged
                => Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 16-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N16 w)
            where T : unmanaged
                => 2/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 32-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N32 w)
            where T : unmanaged
                => 4/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a single 64-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N64 w)
            where T : unmanaged
                => 8/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a single 128-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N128 w)
            where T : unmanaged
                => 16/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a 256-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N256 w)
            where T : unmanaged
                => 32/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of elements that comprise a 512-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<T>(N512 w)
            where T : unmanaged
                => 64/Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the number of T-cells that comprise an N-block
        /// </summary>
        /// <param name="w">The block width representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklen<N,T>(N w = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatMath.div(w,N8.Rep)/Unsafe.SizeOf<T>();

    }

}