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
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 zerohi(BitVector4 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 zerohi(BitVector8 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 zerohi(BitVector16 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 zerohi(BitVector32 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 zerohi(BitVector64 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> zerohi<T>(BitVector<T> src, int pos)
            where T : unmanaged
                => gbits.zerohi(src.data, pos);
    }
}