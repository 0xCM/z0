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

    public static class BitCells
    {
        [MethodImpl(NotInline)]
        public static BitCells<T> alloc<T>(int blocks)        
            where T : unmanaged
                => new BitCells<T>(DataBlocks.alloc<T>(n256,blocks));

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
        public static bit modprod<T>(in BitCells<T> x, in BitCells<T> y)
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

        [MethodImpl(Inline)]
        static int stepsize<T>()
            where T : unmanaged
                => BitCells<T>.StepSize;

        [MethodImpl(Inline)]
        public static BitCells<T> and<T>(in BitCells<T> x,in BitCells<T> y)
            where T : unmanaged
        {
            var z = alloc<T>(x.BlockCount);
            and(x,y,ref z);
            return z;
        }

        [MethodImpl(Inline)]
        public static void and<T>(in BitCells<T> x, in BitCells<T> y, ref BitCells<T> z)        
            where T : unmanaged
                => vblock.and(n256, x.BlockCount, stepsize<T>(), in x.Head, y.Head, ref z.Head);
   }
}