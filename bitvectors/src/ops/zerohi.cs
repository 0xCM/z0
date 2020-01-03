//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class BitVector
    {

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector4 zerohi(BitVector4 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector8 zerohi(BitVector8 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector16 zerohi(BitVector16 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector32 zerohi(BitVector32 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector64 zerohi(BitVector64 src, int pos)
            => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector<T> zerohi<T>(BitVector<T> src, int pos)
            where T : unmanaged
                => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> zerohi<N,T>(BitVector<N,T> src, int pos)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> zerohi<N,T>(in BitVector128<N,T> x)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => ginx.vzerohi(x.data);

    }
}