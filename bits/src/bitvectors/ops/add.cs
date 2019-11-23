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
        /// Computes the arithmetic difference z := x - y for generic bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> add<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.add(x.Data, y.Data);

        [MethodImpl(Inline)]
        public static BitVector4 add2(BitVector4 x, BitVector4 y)
        {
            const int modulus = 16;
            var sum = x.data + y.data;
            var reduced = (byte)((sum >= modulus) ? sum - modulus: sum);
            return new BitVector4(reduced,true);
        }

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 add(BitVector4 x, BitVector4 y)
            => new BitVector4((byte)Mod16.mod(math.add(x.data, y.data)));

        /// <summary>
        /// Computes the arithmetic sum of two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 add(BitVector8 x, BitVector8 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 add(BitVector16 x, BitVector16 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 add(BitVector32 x, BitVector32 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 add(BitVector64 x, BitVector64 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128 add(in BitVector128 x, in BitVector128 y)
        {
            var z = BitVector.alloc(n128);
            Math128.add(in x.x0, in y.x0, ref z.x0);
            return z;
        }
    }
}