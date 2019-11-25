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
    using static nfunc;
    using static As;

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector<T> select<T>(BitVector<T> x, BitVector<T> y, BitVector<T> z)
            where T : unmanaged
                => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> select<N,T>(BitVector<N,T> x, BitVector<N,T> y, BitVector<N,T> z)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector4 select(BitVector4 x, BitVector4 y, BitVector4 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise selection among three source vectors
        /// </summary>
        /// <param name="x">The pivot vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector8 select(BitVector8 x, BitVector8 y, BitVector8 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector16 select(BitVector16 x, BitVector16 y, BitVector16 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector32 select(BitVector32 x, BitVector32 y, BitVector32 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise ternary select for bitvector operands
        /// </summary>
        /// <param name="x">The pivot/mask vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector64 select(BitVector64 x, BitVector64 y, BitVector64 z)
            => gmath.select(x.data, y.data, z.data);

        [MethodImpl(Inline)]
        public static BitVector128 select(in BitVector128 x, in BitVector128 y, in BitVector128 z)
        {
            var selected = BitVector.alloc(n128);
            vblock.select(n128, x.x0, y.x0,z.x0, ref selected.x0);
            return selected;
        }        
    }
}