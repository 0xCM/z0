//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {
        /// <summary>
        /// Stores a 128-bit bitgrid to a caller-supplied target
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="M">The grid row count</typeparam>
        /// <typeparam name="N">THe grid column count</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void store<M,N,T>(BitGrid128<M,N,T> src, Block128<T> dst)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                =>  ginx.vstore(src.data, dst);

        /// <summary>
        /// Allocates and stores a 128-bit bitgrid to a blocked span
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="M">The grid row count</typeparam>
        /// <typeparam name="N">THe grid column count</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> store<M,N,T>(BitGrid128<M,N,T> src)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var dst = DataBlocks.alloc<T>(n128);
            ginx.vstore(src.data, dst);
            return dst;
        }

        /// <summary>
        /// Stores a 256-bit bitgrid to a caller-supplied target
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="M">The grid row count</typeparam>
        /// <typeparam name="N">THe grid column count</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void store<M,N,T>(BitGrid256<M,N,T> src, Block256<T> dst)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                =>  ginx.vstore(src.data, dst);

        /// <summary>
        /// Allocates and stores a 256-bit bitgrid to a blocked span
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="M">The grid row count</typeparam>
        /// <typeparam name="N">THe grid column count</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> store<M,N,T>(BitGrid256<M,N,T> src)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var dst = DataBlocks.alloc<T>(n256);
            ginx.vstore(src.data, dst);
            return dst;
        }

        /// <summary>
        /// Stores a 256-bit cpu vector to an index-identified block
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void store<T>(Vector256<T> src, BitGrid<T> dst, int block)
            where T : unmanaged
                => ginx.vstore(src, dst.Block(block));

        /// <summary>
        /// Stores a 256-bit cpu vector to an index-identified block
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="M">The grid row count</typeparam>
        /// <typeparam name="N">THe grid column count</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void store<M,N,T>(Vector256<T> src, BitGrid<M,N,T> dst, int block)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                =>  ginx.vstore(src, dst.Block(block));

    }
}