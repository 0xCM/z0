//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {

        /// <summary>
        /// Allocates a generic bitgrid
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<T> alloc<T>(int rows, int cols, T zero = default)
            where T : unmanaged
        {            
            var blocksize = n256;
            var blocks = BitCalcs.blockcount<T>(blocksize,rows,cols);
            var data = DataBlocks.alloc<T>(blocksize, blocks); 
            return new BitGrid<T>(data,rows,cols);            
        }

        /// <summary>
        /// Allocates a natural bitgrid
        /// </summary>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> alloc<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var blocksize = n256;
            var blocks = BitCalcs.blockcount<T>(blocksize, natval(m),natval(n));
            var data = DataBlocks.alloc<T>(blocksize, blocks);             
            return new BitGrid<M, N, T>(data);
        }


    }

}