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

    partial class BitVector
    {

        /// <summary>
        /// Computes the GF(256) product of the operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 gfmul(BitVector8 x, BitVector8 y)
            => Gf256.clmul(x,y);

        /// <summary>
        /// Computes the GF(256) product of the operands in-place 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 gfmul(ref BitVector8 x, BitVector8 y)
        {
            x = gfmul(x,y);
            return ref x;
        }
    }
}