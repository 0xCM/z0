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

    public static partial class BitVectorX
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
        /// Extracts a 128-bit cpu vector from a bitsring of length 128 or greater
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type of the target vector</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> ToCpuVector<T>(this BitString src, N128 n)
            where T : unmanaged   
                => src.Pack().As<byte, T>().ToBlock128().LoadVector();

        /// <summary>
        /// Extracts a 128-bit cpu vector from a bitsring of length 128 or greater
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type of the target vector</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> ToCpuVector<T>(this BitString src, N256 n)
            where T : unmanaged
                => src.Pack().As<byte, T>().ToBlock256().LoadVector();

        /// <summary>
        /// Constructs a bitvector from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> ToBitCells<T>(this Span<T> src, int len)
            where T : unmanaged
                => BitCells.from(src,len);
    }
}
