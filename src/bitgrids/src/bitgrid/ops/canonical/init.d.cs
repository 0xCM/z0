//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class BitGrid
    {
        /// <summary>
        /// Creates a dynamically-sized grid of natural dimensions filled with specified data
        /// </summary>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> init<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var blocksize = n256;
            var blocks = Blocks.alloc<T>(blocksize, BitCalcs.tableblocks(blocksize, m,n,d));
            Blocks.broadcast(d, blocks);
            return new BitGrid<M,N,T>(blocks);
        }

        /// <summary>
        /// Initializes a 128-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid16<M,N,T> init16<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged  
                => new BitGrid16<M, N, T>(gvec.broadcast<T,ushort>(d));

        /// <summary>
        /// Initializes a 32-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid32<M,N,T> init32<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid32<M, N, T>(gvec.broadcast<T,uint>(d));

        /// <summary>
        /// Initializes a 64-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid64<M,N,T> init64<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid64<M, N, T>(gvec.broadcast<T,ulong>(d));

        /// <summary>
        /// Initializes a 128-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid128<M,N,T> init128<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid128<M, N, T>(Vectors.vbroadcast(n128, d));

        /// <summary>
        /// Initializes a 256-bit grid of natural dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="d">The fill data</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid256<M,N,T> init256<M,N,T>(M m = default, N n = default, T d = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid256<M,N,T>(Vectors.vbroadcast(n256, d));


    }
}