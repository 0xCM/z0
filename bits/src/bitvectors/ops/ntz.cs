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
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint ntz(BitVector16 x)
            => Bits.ntz(x.data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint nlz(BitVector32 x)
            => Bits.nlz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint ntz(BitVector32 x)
            => Bits.ntz(x.data);

       /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint ntz(BitVector64 x)
            => Bits.ntz(x.data);
    }
}