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
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), Nlz]
        public static int nlz(BitVector4 x)
            => Bits.nlz(x.Data) - x.Width;

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), Nlz]
        public static int nlz(BitVector8 x)
            => Bits.nlz(x.Data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), Nlz]
        public static int nlz(BitVector16 x)
            => Bits.nlz(x.Data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), Nlz]
        public static int nlz(BitVector32 x)
            => Bits.nlz(x.Data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), Nlz]
        public static int nlz(BitVector64 x)
            => Bits.nlz(x.Data);
    }
}