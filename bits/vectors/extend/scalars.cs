//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class BitVectorX
    {
        /// <summary>
        /// Defines a 16-bit bitvector from the lo 16 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this uint src, N16 n)        
            => (ushort)src;

        /// <summary>
        /// Constructs a canonical 8-bit bitvector from an 8-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this byte src)
            => src;

        /// <summary>
        /// Constructs a canonical 32-bit bitvector from a 32-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this uint src)
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector with content determined by a 32-bit usigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this int src)        
            => (uint)src;

        /// <summary>
        /// Constructs a 16-bit bitvector from a 16-bit scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this ushort src)
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector from a 64-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this ulong src)
            => src;

        /// <summary>
        /// Creates a 24-bit bitvector from an 8-bit scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector24 ToBitVector(this byte src, N24 n)
            => src;

        /// <summary>
        /// Creates a 24-bit bitvector from a 16-bit scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector24 ToBitVector(this ushort src, N24 n)
            => src;

        /// <summary>
        /// Creates a 24-bit bitvector from a 32-bit scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector24 ToBitVector(this uint src, N24 n)
            => src;

        /// <summary>
        /// Creates a 24-bit bitvector from a 64-bit scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector24 ToBitVector(this ulong src, N24 n)
            => (uint)src;
   }
}