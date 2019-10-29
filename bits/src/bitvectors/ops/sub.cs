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
        /// Computes a new vector z := x - y that forms the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> sub<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.sub(x.Data, y.Data);

        /// <summary>
        /// Computes a new vector z := x - y that forms the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 sub(BitVector4 x, BitVector4 y)
            => (byte)Mod16.mod(math.sub((uint)x.data, (uint)y.data));

        /// <summary>
        /// Computes a new vector z := x - y that forms the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 sub(BitVector8 x, BitVector8 y)
            => math.sub(x.data, y.data);

        /// <summary>
        /// Computes a new vector z := x - y that forms the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 sub(BitVector16 x, BitVector16 y)
            => math.sub(x.data, y.data);

        /// <summary>
        /// Computes a new vector z := x - y that forms the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 sub(BitVector32 x, BitVector32 y)
            => math.sub(x.data, y.data);

        /// <summary>
        /// Computes a new vector z := x - y that forms the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 sub(BitVector64 x, BitVector64 y)
            => math.sub(x.data, y.data);


    }
}