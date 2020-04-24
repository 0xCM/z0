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
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(BitVector<T> x, BitFormatConfig? fmt = null)
            where T : unmanaged
                => bitstring(x).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline)]
        public static string format<N,T>(in BitVector128<N,T> x, BitFormatConfig? fmt = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => bitstring(x).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline)]
        public static string format<N,T>(BitVector<N,T> x, BitFormatConfig? fmt = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => bitstring(x).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector4 src, BitFormatConfig? fmt = null)
            => bitstring(src).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector8 x, BitFormatConfig? fmt = null)
            => bitstring(x).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector16 x, BitFormatConfig? fmt = null)
            => bitstring(x).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector24 x, BitFormatConfig? fmt = null)
            => bitstring(x).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector32 x, BitFormatConfig? fmt = null)
            => bitstring(x).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector64 x, BitFormatConfig? fmt = null)
            => bitstring(x).Format(fmt);
    }
}