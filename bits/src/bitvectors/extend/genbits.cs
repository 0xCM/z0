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