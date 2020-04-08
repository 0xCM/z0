//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; using static Memories;

    partial class BitVector
    {
        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="index">The position of the bit to enable</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> enable<T>(BitVector<T> x, int index)
            where T : unmanaged
                => gbits.enable(x.data,index);

        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 enable(BitVector4 x, int index)
            => Bits.enable(x.data, index);

        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="index">The position of the bit to enable</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 enable(BitVector8 x, int index)
            => Bits.enable(x.data, index);

        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="index">The position of the bit to enable</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 enable(BitVector16 x, int index)
            => Bits.enable(x.data, index);

        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="index">The position of the bit to enable</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 enable(BitVector32 x, int index)
            => Bits.enable(x.data, index);

        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="index">The position of the bit to enable</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 enable(BitVector64 x, int index)
            => Bits.enable(x.data, index);
    }
}