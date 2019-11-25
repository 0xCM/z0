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
            => BitVector.from(n,src);

        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 Reverse(this BitVector4 src)
            => BitVector.rev(src);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector4 Replicate(this BitVector4 src)
            => new BitVector4(src.data,true);

        /// <summary>
        /// Creates a new vector via concatenation
        /// </summary>
        /// <param name="tail">The lower bits of the new vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 Concat(this BitVector4 head, BitVector4 tail)
            => BitVector.from(n8,head.data << 4 | tail.data);

        [MethodImpl(Inline)]
        public static BitVector8 Replicate(this BitVector4 src, N2 n)
            => src.Concat(src);

        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector4 src)
            => BitString.from(src.Scalar, src.Width);
            
        [MethodImpl(Inline)]
        public static string Format(this BitVector4 src,bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier, blockWidth);

    }

}