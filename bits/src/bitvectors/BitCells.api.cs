//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    

    public static class BitCells
    {
        /// <summary>
        /// Allocates a 1-cell generic bitvector, optionally initialized to a specified value
        /// </summary>
        /// <param name="init">The initial value</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> alloc<T>(T? init = null)
            where T : unmanaged
                => BitCells<T>.FromCell(init ?? default);
            
        /// <summary>
        /// Allocates a generic bitvector
        /// </summary>
        /// <param name="len">The length</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> alloc<T>(int len, T? fill = null)
            where T : unmanaged
                => BitCells<T>.Alloc(len, fill);

        /// <summary>
        /// Loads a generic bitvector from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The vector length</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> load<T>(Span<T> src, int n)
            where T : unmanaged
                => BitCells<T>.FromCells(src, n);

        /// <summary>
        /// Defines a generic bitvector with a specified number of components and bitlength
        /// </summary>
        /// <param name="n">The number of components (bits) in the vector</param>
        /// <param name="src">The source from which the bits will be extracted</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> load<T>(T[] src, int n)
            where T : unmanaged
                => BitCells<T>.From(src,n);

        /// <summary>
        /// Creates a generic bitvector defined by an arbitrary number of segments
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitCells<T> load<T>(params T[] src)
            where T : unmanaged
                => BitCells<T>.From(src, bitsize<T>()*src.Length);
 
        /// <summary>
        /// Computes the number of cells required to hold a specified number of bits
        /// </summary>
        /// <param name="len">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static int cells<T>(int len)
            where T : unmanaged
                => BitCells<T>.CellCount(len);

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        public static bit modprod<T>(BitCells<T> x, BitCells<T> y)
            where T : unmanaged
        {
            var result = 0u;
            for(var i=0; i<x.Length; i++)
            {
                var a = (uint)x[i];
                var b = (uint)y[i];
                result += a*b;
            }
            return odd(result);
        }

   }
}