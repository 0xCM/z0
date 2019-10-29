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
        /// Computes the bitwise NOR between generic source vectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <typeparam name="T">The primal bitvector type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> nor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.nor(x.Data, y.Data);

        /// <summary>
        /// Computes the bitwise NOR between two source vectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 nor(BitVector4 x, BitVector4 y)
            => math.nor(x.data, y.data);

        /// <summary>
        /// Computes the bitwise NOR between two source vectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 nor(BitVector8 x, BitVector8 y)
            => math.nor(x.data, y.data);

        /// <summary>
        /// Computes the bitwise NOR between two source vectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 nor(BitVector16 x, BitVector16 y)
            => math.nor(x.data, y.data);

        /// <summary>
        /// Computes the bitwise NOR between two source vectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 nor(BitVector32 x, BitVector32 y)
            => math.nor(x.data, y.data);

        /// <summary>
        /// Computes the bitwise NOR between two source vectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 nor(BitVector64 x, BitVector64 y)
            => math.nor(x.data, y.data);
 
    }
}