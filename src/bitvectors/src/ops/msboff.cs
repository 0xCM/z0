//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitVector
    {
        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), MsbOff, Closures(UnsignedInts)]
        public static BitVector<T> msboff<T>(BitVector<T> src, byte pos)
            where T : unmanaged
                => gbits.msboff(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> msboff<N,T>(BitVector<N,T> src, byte pos)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.msboff(src.Data, pos);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> msboff<N,T>(in BitVector128<N,T> x)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gcpu.vzerohi(x.Data);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), MsbOff]
        public static BitVector4 msboff(BitVector4 src, byte pos)
            => gbits.msboff(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), MsbOff]
        public static BitVector8 msboff(BitVector8 src, byte pos)
            => gbits.msboff(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), MsbOff]
        public static BitVector16 msboff(BitVector16 src, byte pos)
            => gbits.msboff(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), MsbOff]
        public static BitVector32 msboff(BitVector32 src, byte pos)
            => gbits.msboff(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), MsbOff]
        public static BitVector64 msboff(BitVector64 src, byte pos)
            => gbits.msboff(src.Data, pos);
    }
}