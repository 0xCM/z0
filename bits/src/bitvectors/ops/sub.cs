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
        /// Computes the bitvector z: = x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> sub<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.sub(x.Data, y.Data);

        /// <summary>
        /// Computes the bitvector z: = x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 sub(BitVector4 x, BitVector4 y)
            => (byte)Mod16.mod(math.sub((uint)x.data, (uint)y.data));

        /// <summary>
        /// Computes the bitvector z: = x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 sub(BitVector8 x, BitVector8 y)
            => gmath.sub(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z: = x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 sub(BitVector16 x, BitVector16 y)
            => gmath.sub(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z: = x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 sub(BitVector32 x, BitVector32 y)
            => gmath.sub(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z: = x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 sub(BitVector64 x, BitVector64 y)
            => gmath.sub(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z: = x - y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128 sub(BitVector128 x, BitVector128 y)
        {
            var z = alloc(n128);
            vblock.sub(n128, in x.x0, in y.x0, ref z.x0);
            return z;
        }


    }
}