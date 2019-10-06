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
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        public static Bit dot(BitVector4 lhs, BitVector4 rhs)
            => odd((uint)Bits.pop(lhs.data & rhs.data));              

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit dot(BitVector8 lhs, BitVector8 rhs)
            => odd(Bits.pop(lhs.data & rhs.data));              

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit dot(BitVector16 lhs, BitVector16 rhs)
            => odd(Bits.pop(lhs.data & rhs.data));              

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit dot(BitVector32 lhs, BitVector32 rhs)
            => odd(Bits.pop(lhs.data & rhs.data));              


        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit dot(BitVector64 lhs, BitVector64 rhs)
            => odd(Bits.pop(lhs.data & rhs.data));   //mod<N2>(Bits.pop(lhs.data & rhs.data));              

    }

}