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

    partial class BitGrid
    {

        /// <summary>
        /// Computes the number of segments required to cover a grid
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The bit-width of a storage segment</param>
        [MethodImpl(Inline)]
        public static int segcount(ushort rows, ushort cols, ushort segwidth)
        {
            var bytes = bytecount(rows, cols);
            var segbytes = segwidth / 8;
            var segs = bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);            
            return segs;
        }

        /// <summary>
        /// Computes the number of segments required to cover a grid, predicated on the 
        /// bit-width of the parametric storage segment type
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static int segcount<T>(ushort rows, ushort cols)
            where T : unmanaged
                => segcount(rows,cols, (ushort)bitsize<T>());
        
        /// <summary>
        /// Computes the number of segments required cover a grid as characterized by parametric type information
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="zero">The segment type zero representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static int segcount<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => segcount(natval(m), natval(n), (ushort)bitsize<T>());
    }

}