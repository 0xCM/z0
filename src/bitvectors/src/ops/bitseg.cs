//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitVector
    {
        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Extract, Closures(Closure)]
        public static BitVector<T> bitseg<T>(BitVector<T> x, byte first, byte last)
            where T : unmanaged
                => gbits.extract(x.Data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> bitseg<N,T>(BitVector<N,T> x, byte first, byte last)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.extract(x.Data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Extract]
        public static BitVector4 bitseg(BitVector4 x, byte first, byte last)
            => Bits.extract(x.Data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Extract]
        public static BitVector8 bitseg(BitVector8 x, byte first, byte last)
            => Bits.extract(x.Data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Extract]
        public static BitVector16 bitseg(BitVector16 x, byte first, byte last)
            => Bits.extract(x.Data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Extract]
        public static BitVector32 bitseg(BitVector32 x, byte first, byte last)
            => Bits.extract(x.Data, first, last);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), Extract]
        public static BitVector64 bitseg(BitVector64 x, byte first, byte last)
            => Bits.extract(x.Data, first, last);
    }
}