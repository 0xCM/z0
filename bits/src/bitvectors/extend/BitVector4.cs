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
        /// Constructs a 4-bit bitvector from the lower 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector(this byte src, N4 n)
            => src;

        /// <summary>
        /// Constructs a 4-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector(this BitString src, N4 n)
            => BitVector4.FromBitString(src);

        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 Reverse(this BitVector4 src)
            => BitVector.rev(src);

    }

}