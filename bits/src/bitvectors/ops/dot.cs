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
                
        [MethodImpl(Inline)]
        public static bit dot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var result = bit.Off;
            for(var i=0; i<x.Length; i++)
                result ^= x[i] & y[i];
            return result;
        }

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        public static bit dot(BitVector4 x, BitVector4 y)
            => odd((uint)Bits.pop(x.data & y.data));              

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit dot(BitVector8 x, BitVector8 y)
            => odd(Bits.pop(x.data & y.data));              

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit dot(BitVector16 x, BitVector16 y)
            => odd(Bits.pop(x.data & y.data));              

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit dot(BitVector32 x, BitVector32 y)
            => odd(Bits.pop(x.data & y.data));              

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit dot(BitVector64 x, BitVector64 y)
            => odd(Bits.pop(x.data & y.data));


    }

}