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
        /// Constructs a 128-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this BitString src, N128 n)
            => BitVector.from(n,src);

        /// <summary>
        /// Creates a 128-bit bitvector from a 8-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this sbyte src, N128 n)        
            => (byte)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 8-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this byte src, N128 n)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 16-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this short src, N128 n)        
            => (ushort)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 16-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this ushort src, N128 n)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 32-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this int src, N128 n)        
            => (uint)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 32-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this uint src, N128 n)        
            => src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 64-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this long src, N128 n)        
            => (ulong)src;

        /// <summary>
        /// Creates a 128-bit bitvector from a 64-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 ToBitVector(this ulong src, N128 n)        
            => src;

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector128 Replicate(this BitVector128 src)
            => new BitVector128(src.x0,src.x1);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv8
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector8(this BitVector128 src)
            => BitVector8.FromScalar(src.x0);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv16
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector16(this BitVector128 src)
            => BitVector16.FromScalar(src.x0);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv32
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this BitVector128 src)
            => BitVector.from(n32,src.x0);

        /// <summary>
        /// Applies the identity conversion Bv64 -> Bv64
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector64(this BitVector128 src)
            => BitVector.from(n64, src.x0);

        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector128 src)
            => BitString.from(src.x1) + BitString.from(src.x0);

        [MethodImpl(Inline)]
        public static string FormatBits(this BitVector128 src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier, blockWidth);
    }
}