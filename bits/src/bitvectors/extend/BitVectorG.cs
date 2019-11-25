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
        /// Constructs a generic bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this BitString src)
            where T : unmanaged
                => BitVector.generic<T>(src);

        [MethodImpl(Inline)]
        public static BitCells<T> ToCells<T>(this BitVector<T> src)
            where T : unmanaged
                => BitCells.literals(src.Scalar);

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

        /// <summary>
        /// Sets all the bits to align with the source value
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static void Fill<T>(this BitVector<T> src, bit value)
            where T : unmanaged
             => src.data = gmath.mul(gmath.maxval<T>(), convert<uint,T>((uint)value));

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitVector<T> src)
            where T : unmanaged
                => BitString.from<T>(src.Scalar); 

        /// <summary>
        /// Extracts the represented data as a bitstring truncated to a specified width
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitVector<T> src, int width)
            where T : unmanaged
                => BitString.from<T>(src.Scalar,width);

        /// <summary>
        /// Clones the vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<T> Replicate<T>(this BitVector<T> src)
            where T : unmanaged
                => src.Scalar;

        [MethodImpl(Inline)]
        public static BitVector<T> Reverse<T>(this BitVector<T> src)
            where T : unmanaged
                => BitVector.rev(src);

        [MethodImpl(Inline)]
        public static string Format<T>(this BitVector<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            where T : unmanaged
                => src.ToBitString().Format(tlz, specifier, blockWidth);
    }
}