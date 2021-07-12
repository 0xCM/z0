//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    partial class BitVector
    {
        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(BitVector4 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(BitVector8 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(BitVector16 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(BitVector64 x)
            => x.Width - nlz(x);
    }
}