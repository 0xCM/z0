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
        /// Sets the state of a grid bit identified by its linear position
        /// </summary>
        /// <param name="bitpos">The 0-based linear bit index</param>
        /// <param name="state">The source state</param>
        /// <param name="dst">A reference to the grid storage</param>
        /// <typeparam name="T">The grid storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void setbit<T>(int bitpos, bit state, ref T dst)    
            where T : unmanaged
                => cell(ref dst, bitpos) = gbits.setbit(cell(ref dst, bitpos), (byte)(bitpos % bitsize<T>()), state);      

        /// <summary>
        /// Sets the state of an a coordinate-identified bit
        /// </summary>
        /// <param name="M">The number of rows in the grid</param>
        /// <param name="N">The number of columns in the grid</param>
        /// <param name="row">The row of interest</param>
        /// <param name="col">The column of interest</param>
        /// <param name="state">The source state</param>
        /// <typeparam name="T">The grid storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void setbit<T>(int width, int row, int col, bit state, ref T dst)    
            where T : unmanaged
                => setbit(BitCalcs.bitindex(width,row,col), state, ref dst);

        /// <summary>
        /// Sets the state of an a coordinate-identified bit
        /// </summary>
        /// <param name="M">The number of rows in the grid</param>
        /// <param name="N">The number of columns in the grid</param>
        /// <param name="row">The row of interest</param>
        /// <param name="col">The column of interest</param>
        /// <param name="state">The source state</param>
        /// <typeparam name="T">The grid storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void setbit<N,T>(N width, int row, int col, bit state, ref T dst)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => setbit(BitCalcs.bitindex(nati(width),row,col), state, ref dst);
    }
}