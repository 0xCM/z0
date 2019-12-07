//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {
        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<byte> ToGeneric(this BitVector8 src)
            => src.data;

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<ushort> ToGeneric(this BitVector16 src)
            => src.data;

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<uint> ToGeneric(this BitVector32 src)
            => src.data;

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<ulong> ToGeneric(this BitVector64 src)
            => src.data;

        /// <summary>
        /// Defines an 8-bit generic bitvector from an unsigned integer of commensurate width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<byte> ToGenericBits(this byte src)
            => src;

        /// <summary>
        /// Defines a 16-bit generic bitvector from an unsigned integer of commensurate width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<ushort> ToGenericBits(this ushort src)
            => src;

        /// <summary>
        /// Defines a 32-bit generic bitvector from an unsigned integer of commensurate width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<uint> ToGenericBits(this uint src)
            => src;

        /// <summary>
        /// Defines a 64-bit generic bitvector from an unsigned integer of commensurate width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<ulong> ToGenericBits(this ulong src)
            => src;        
    }
}