//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class BitGrid
    {
        /// <summary>
        /// Reads/manipulates a cell identified by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T cell<T>(ref T src, int bitpos)
            where T : unmanaged
                => ref seek(ref src, bitpos / bitsize<T>()); 

        /// <summary>
        /// Reads/manipulates a cell identified by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T cell<T>(in BitGrid<T> src, int bitpos)
            where T : unmanaged
                => ref seek(ref src.Head, bitpos / bitsize<T>()); 

        /// <summary>
        /// Reads/manipulates a cell identified by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<M,N,T>(in BitGrid<M,N,T> src, int bitpos)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => ref seek(ref src.Head, bitpos / bitsize<T>()); 
 
        [MethodImpl(Inline)]
        public static RowBits<T> rowcells<M,N,T>(in BitGrid<M,N,T> g, int row)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            int rowcells = (nati<N>() / 8)/size<T>();
            int rowoffset = ((row*nati<N>())/8)/size<T>();
            return RowBits.load(g.Data.Slice(rowoffset, rowcells));
        }
    }
}