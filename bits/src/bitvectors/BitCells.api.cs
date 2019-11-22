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
                => new BitCells<T>(src, n);

        /// <summary>
        /// Creates a generic bitvector defined by an arbitrary number of segments
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitCells<T> load<T>(params T[] src)
            where T : unmanaged
                => new BitCells<T>(src, bitsize<T>()*src.Length);
 
        /// <summary>
        /// Computes the number of cells required to hold a specified number of bits
        /// </summary>
        /// <param name="len">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static int cellcount<T>(int len)
            where T : unmanaged
        {
            var q = Math.DivRem(len, bitsize<T>(), out int r);            
            return r == 0 ? q : q + 1;
        }

        /// <summary>
        /// Creates a bitvector from a span of bytes
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitvector length</param>
        public static BitCells<T> loadbytes<T>(Span<byte> src, int n)
            where T : unmanaged
        {
            var q = Math.DivRem(src.Length, size<T>(), out int r);
            var cellcount = r == 0 ? q : q + 1;
            var capacity = size<T>();
            
            var cells = new T[cellcount];
            for(int i=0, offset = 0; i< cellcount; i++, offset += capacity)
                cells[i] = src.Slice(offset).TakeScalar<T>();
            return new BitCells<T>(cells, n);
        }

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
                => 256 / bitsize<T>();

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

        /// <summary>
        /// Computes the scalar product between this vector and another of identical length
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit dot<T>(in BitCells<T> x, in BitCells<T> y)
            where T : unmanaged
        {
            var result = bit.Off;
            for(var i=0; i<x.Length; i++)
                result ^= x[i] & y[i];
            return result;
        }


   }
}