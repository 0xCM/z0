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
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The position of the bit to disable</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> disable<T>(BitVector<T> x, int index)
            where T : unmanaged
                => gbits.disable(x.Data,index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> disable<N,T>(BitVector<N,T> x, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.disable(x.Data,index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 disable(BitVector4 x, int index)
            => Bits.disable(x.Data, index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 disable(BitVector8 x, int index)
            => Bits.disable(x.Data, index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 disable(BitVector16 x, int index)
            => Bits.disable(x.Data, index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 disable(BitVector32 x, int index)
            => Bits.disable(x.Data, index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 disable(BitVector64 x, int index)
            => Bits.disable(x.Data, index);
    }
}