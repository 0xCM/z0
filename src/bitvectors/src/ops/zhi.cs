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
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), ZHi, Closures(UnsignedInts)]
        public static BitVector<T> zhi<T>(BitVector<T> src, int pos)
            where T : unmanaged
                => gbits.zhi(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> zhi<N,T>(BitVector<N,T> src, int pos)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.zhi(src.Data, pos);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> zhi<N,T>(in BitVector128<N,T> x)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gvec.vzerohi(x.Data);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), ZHi]
        public static BitVector4 zhi(BitVector4 src, int pos)
            => gbits.zhi(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), ZHi]
        public static BitVector8 zhi(BitVector8 src, int pos)
            => gbits.zhi(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), ZHi]
        public static BitVector16 zhi(BitVector16 src, int pos)
            => gbits.zhi(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), ZHi]
        public static BitVector32 zhi(BitVector32 src, int pos)
            => gbits.zhi(src.Data, pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline), ZHi]
        public static BitVector64 zhi(BitVector64 src, int pos)
            => gbits.zhi(src.Data, pos);
    }
}