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

    partial class bitvector
    {
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
        /// Computes the in-place arithmetic difference x := x - y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 sub(ref BitVector8 x, in BitVector8 y)
        {
            math.sub(ref x.data, y.data);
            return ref x;
        }

        /// <summary>
        /// Computes a new vector z := x - y that forms the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 sub(BitVector16 x, BitVector16 y)
            => math.sub(x.data, y.data);

        /// <summary>
        /// Computes the in-place arithmetic difference x := x - y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 sub(ref BitVector16 x, in BitVector16 y)
        {
            math.sub(ref x.data, y.data);
            return ref x;
        }

        /// <summary>
        /// Computes a new vector z := x - y that forms the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 sub(BitVector32 x, BitVector32 y)
            => math.sub(x.data, y.data);

        /// <summary>
        /// Computes the in-place arithmetic difference x := x - y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 sub(ref BitVector32 x, in BitVector32 y)
        {
            math.sub(ref x.data, y.data);
            return ref x;
        }

        /// <summary>
        /// Computes a new vector z := x - y that forms the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 sub(BitVector64 x, BitVector64 y)
            => math.sub(x.data, y.data);

        /// <summary>
        /// Computes the in-place arithmetic difference x := x - y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 sub(ref BitVector64 x, in BitVector64 y)
        {
            math.sub(ref x.data, y.data);
            return ref x;
        }

    }
}