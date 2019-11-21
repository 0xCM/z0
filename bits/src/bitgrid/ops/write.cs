//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitGrid
    {
        /// <summary>
        /// Retrieves a reference to the segment determined by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static ref T segment<T>(int bitpos, ref T src)            
            where T : unmanaged   
                => ref seek(ref src, bitpos / bitsize<T>());

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
                => gbits.set(ref segment(bitpos, ref dst), (byte)(bitpos % bitsize<T>()), state);      

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
                => setbit(bitpos(width,row,col), state, ref dst);

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
                => setbit(bitpos(natval(width),row,col), state, ref dst);
    }
}