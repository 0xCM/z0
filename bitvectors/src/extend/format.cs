//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; using static Memories;

    partial class BitVectorX
    {
        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="fmt">Bitstring formatting specifications</param>
        [MethodImpl(Inline)]
        public static string Format(this BitVector4 src, BitFormatConfig? fmt = null)
            => BitVector.format(src,fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="fmt">Bitstring formatting specifications</param>
        [MethodImpl(Inline)]
        public static string Format(this BitVector8 src, BitFormatConfig? fmt = null)
            => BitVector.format(src,fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="fmt">Bitstring formatting specifications</param>
        [MethodImpl(Inline)]
        public static string Format(this BitVector32 src, BitFormatConfig? fmt = null)
            => BitVector.format(src, fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="fmt">Bitstring formatting specifications</param>
        [MethodImpl(Inline)]
        public static string Format(this BitVector16 src, BitFormatConfig? fmt = null)
            => BitVector.format(src, fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="fmt">Bitstring formatting specifications</param>
        [MethodImpl(Inline)]
        public static string Format(this BitVector24 src, BitFormatConfig? fmt = null)
            => BitVector.format(src, fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="fmt">Bitstring formatting specifications</param>
        [MethodImpl(Inline)]
        public static string Format(this BitVector64 src, BitFormatConfig? fmt = null)
            => BitVector.format(src, fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="fmt">Bitstring formatting specifications</param>
        [MethodImpl(Inline)]
        public static string Format<N,T>(this BitVector<N,T> src, BitFormatConfig? fmt = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.format(src,fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="fmt">Bitstring formatting specifications</param>
        [MethodImpl(Inline)]
        public static string Format<T>(this BitVector<T> src, BitFormatConfig? fmt = null)
            where T : unmanaged
                => BitVector.format(src,fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="fmt">Bitstring formatting specifications</param>
        [MethodImpl(Inline)]
        public static string Format<N,T>(this BitVector128<N,T> src, BitFormatConfig? fmt = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.format(src, fmt);
    }
}