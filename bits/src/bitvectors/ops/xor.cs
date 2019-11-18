//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitvector z: = x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.xor(x.Data,y.Data);

        /// <summary>
        /// Computes the bitvector z: = x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 xor(BitVector4 x, BitVector4 y)
            => gmath.xor(x.data,y.data);

        /// <summary>
        /// Computes the bitvector z: = x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 xor(BitVector8 x, BitVector8 y)
            => gmath.xor(x.data,y.data);

        /// <summary>
        /// Computes the bitvector z: = x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 xor(BitVector16 x, BitVector16 y)
            => gmath.xor(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z: = x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 xor(BitVector32 x, BitVector32 y)
            => gmath.xor(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z: = x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 xor(BitVector64 x, BitVector64 y)
            => gmath.xor(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z: = x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128 xor(BitVector128 x, BitVector128 y)
        {
            var z = alloc(n128);
            vblock.xor(n128, in x.x0, in y.x0, ref z.x0);
            return z;
        }
    }
}