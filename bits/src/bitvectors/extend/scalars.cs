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
        /// Creates an an 8-bit bitvector via the obvious canonical bijection
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this byte src, N8 n)        
            => src;

        /// <summary>
        /// Creates an an 8-bit bitvector from the lower 8 bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this ushort src, N8 n)        
            => (byte)src;

        /// <summary>
        /// Defines a 16-bit bitvector from the lo 16 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this uint src, N16 n)        
            => (ushort)src;

        /// <summary>
        /// Defines a 32-bit bitvector with content determined by a 32-bit usigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this int src, N32 n)        
            => (uint)src;

        /// <summary>
        /// Defines a 16-bit bitvector with content determined by its corresponding integral type 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this int src, N16 n)        
            => (ushort)src;

        /// <summary>
        /// Defines a 64-bit bitvector where the lower 16 bits are determined by 
        /// an 8-bit usigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this byte src, N64 n)        
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector where the lower 8 bits are 
        /// determined by an 8-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this sbyte src, N64 n)        
            => (byte)src;

        /// <summary>
        /// Defines a 64-bit bitvector where the lower 16 bits are determined by a 16-bit usigned integer 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this ushort src, N64 n)        
            => src;
            
        /// <summary>
        /// Defines a 64-bit bitvector where the lower 16 bits are determined by a 16-bit signed integer 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this short src, N64 n)        
            => (ushort)src;

        /// <summary>
        /// Defines a 64-bit bitvector where the lower 32 bits are determined by a 32-bit unsigned integer 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this uint src, N64 n)        
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this int src, N64 n)        
            => (uint)src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this long src, N64 n)        
            => (ulong)src;

        /// <summary>
        /// Constructs a 64-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this ulong src, N64 n)        
            => src;

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
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this sbyte src, N32 n)        
            => (byte)src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this byte src, N32 n)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this ushort src, N32 n)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this short src, N32 n)        
            => (ushort)src;

        /// <summary>
        /// Defines a 32-bit bitvector with content determined by its corresponding integral type 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this uint src, N32 n)        
            => src;

        /// <summary>
        /// Constructs a 4-bit bitvector from the lower 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector(this byte src, N4 n)
            => src;

        /// <summary>
        /// Constructs a 16-bit bitvector from a 16-bit scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this ushort src, N16 n = default)
            => src;

        /// <summary>
        /// Creates a 16-bit bitvector with the lower 8 bits populated by the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this byte src, N16 n)        
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector from a 64-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this ulong src)
            => src;

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

   }
}