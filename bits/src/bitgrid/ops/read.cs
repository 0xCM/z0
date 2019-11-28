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
        /// Loads a 256-bit cpu vector from an index-identified block
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> read<T>(BitGrid<T> src, int block)
            where T : unmanaged
                => ginx.vload(src.Block(block));          

        /// <summary>
        /// Loads a 256-bit cpu vector from an index-identified block
        /// </summary>
        /// <param name="src">The source grid</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> read<M,N,T>(BitGrid<M,N,T> src, int block)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                =>  ginx.vload(src.Block(block));          

        /// <summary>
        /// Reads a cell determined by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        static ref readonly T readcell<T>(in T src, int bitpos)
            where T : unmanaged
                => ref skip(in src, bitpos / bitsize<T>()); 

        [MethodImpl(Inline)]
        public static bit readbit<T>(in T src, int bitpos)
            where T : unmanaged   
                => gbits.test(readcell(in src, bitpos), bitpos % bitsize<T>());

        /// <summary>
        /// Reads a bit from a grid
        /// </summary>
        [MethodImpl(Inline)]
        public static bit readbit<N,T>(N width, in T src, int row, int col)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => readbit(in src, natval<N>()*row + col);

        /// <summary>
        /// Reads a bit from a grid
        /// </summary>
        [MethodImpl(Inline)]
        public static bit readbit<T>(int width, in T src, int row, int col)
            where T : unmanaged
                => readbit(in src, width*row + col);
    }
}