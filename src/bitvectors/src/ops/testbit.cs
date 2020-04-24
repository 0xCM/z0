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
        /// Determines whether an index-identified bit is enabled
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), TestBit, Closures(UnsignedInts)]
        public static bit testbit<T>(BitVector<T> x, byte index)
            where T : unmanaged
                => gbits.testbit(x.Data, index);

        /// <summary>
        /// Determines whether an index-identified bit is enabled
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public static bit testbit<N,T>(BitVector<N,T> x, byte index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.testbit(x.Data, index);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(BitVector4 x, byte pos)
            => Bits.testbit(x.Data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(BitVector8 x, byte pos)
            => Bits.testbit(x.Data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(BitVector16 x, byte pos)
            => Bits.testbit(x.Data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(BitVector32 x, byte pos)
            => Bits.testbit(x.Data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(BitVector64 x, byte pos)
            => Bits.testbit(x.Data, pos);
    }
}