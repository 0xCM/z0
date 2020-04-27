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

    partial class BitGridA
    {
        /// <summary>
        /// Computes the bitwise AND between generic bitgrids and returns the allocated result
        /// </summary>
        /// <param name="gx">The left grid</param>
        /// <param name="gy">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), And, Closures(UnsignedInts)]
        public static BitGrid<T> and<T>(in BitGrid<T> gx, in BitGrid<T> gy)
            where T : unmanaged
        {
            var gz = BitGrid.alloc<T>(gx.RowCount, gx.ColCount);
            BitGrid.and(gx,gy,gz);
            return gz;
        }

        /// <summary>
        /// Computes the bitwise AND between generic bitgrids and returns the allocated result
        /// </summary>
        /// <param name="a">The left grid</param>
        /// <param name="b">The right grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> and<M,N,T>(in BitGrid<M,N,T> a, in BitGrid<M,N,T> b)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var gz = BitGrid.alloc<M,N,T>();    
            BitGrid.and(a,b,gz);
            return gz;
        }
    }
}