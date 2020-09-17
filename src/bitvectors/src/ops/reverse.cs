//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class BitVector
    {
        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Reverse, Closures(UnsignedInts)]
        public static BitVector<T> reverse<T>(BitVector<T> x)
            where T : unmanaged
                => gbits.reverse(x.Data);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> reverse<N,T>(BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.srl(gbits.reverse(src.Data), (byte)(bitwidth<T>() - src.Width));

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Reverse]
        public static BitVector4 reverse(BitVector4 x)
            => Bits.reverse(x.Data);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Reverse]
        public static BitVector8 reverse(BitVector8 x)
            => Bits.reverse(x.Data);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Reverse]
        public static BitVector16 reverse(BitVector16 x)
            => Bits.reverse(x.Data);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Reverse]
        public static BitVector32 reverse(BitVector32 x)
            => Bits.reverse(x.Data);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Reverse]
        public static BitVector64 reverse(BitVector64 x)
            => Bits.reverse(x.Data);
    }
}