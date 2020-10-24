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
        /// Determines whether an index-identified bit is enabled
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline), TestBit, Closures(Closure)]
        public static Bit32 testbit<T>(BitVector<T> x, byte index)
            where T : unmanaged
                => gbits.testbit(x.Data, index);

        /// <summary>
        /// Determines whether an index-identified bit is enabled
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public static Bit32 testbit<N,T>(BitVector<N,T> x, byte index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.testbit(x.Data, index);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(BitVector4 x, byte pos)
            => Bits.testbit32(x.Data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(BitVector8 x, byte pos)
            => Bits.testbit32(x.Data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(BitVector16 x, byte pos)
            => Bits.testbit32(x.Data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(BitVector32 x, byte pos)
            => Bits.testbit32(x.Data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(BitVector64 x, byte pos)
            => Bits.testbit32(x.Data, pos);
    }
}