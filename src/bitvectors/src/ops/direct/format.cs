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
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector4 src, BitFormat? fmt = null)
            => bitstring(src).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector8 x, BitFormat? fmt = null)
            => BitFormatter.create<byte>(fmt).Format(x);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector16 x, BitFormat? fmt = null)
            => BitFormatter.create<ushort>(fmt).Format(x);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector24 x, BitFormat? fmt = null)
            => BitFormatter.create<uint>(fmt).Format(x);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector32 x, BitFormat? fmt = null)
            => BitFormatter.create<uint>(fmt).Format(x);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline), Op]
        public static string format(BitVector64 x, BitFormat? fmt = null)
            => BitFormatter.create<ulong>(fmt).Format(x);
    }
}