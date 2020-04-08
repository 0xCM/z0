//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    partial class BitVector
    {
        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 seg(BitVector4 x, byte first, byte last)
            => Bits.between(x.data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 seg(BitVector8 x, byte first, byte last)
            => Bits.between(x.data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 seg(BitVector16 x, byte first, byte last)
            => Bits.between(x.data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 seg(BitVector32 x, byte first, byte last)
            => Bits.between(x.data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 seg(BitVector64 x, byte first, byte last)
            => Bits.between(x.data, first, last);
 
        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> seg<T>(BitVector<T> x, byte first, byte last)
            where T : unmanaged
                => gbits.between(x.data, first, last);

    }
}