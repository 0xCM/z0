//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;

    partial class BitVector
    {
        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector<T> from<T>(BitString src)
            where T : unmanaged
                => src.TakeScalar<T>();

        /// <summary>
        /// Allocates and fills a byte-secialized generic bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<byte> generic(N8 n8, byte init)
            => init;

        /// <summary>
        /// Allocates and fills a byte-secialized generic bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<byte> generic(N8 n, bit b0, bit b1, bit b2, bit b3)
            => from(n, b0, b1, b2, b3);

        /// <summary>
        /// Creates a 4-bit bitvector from 4 explicit bits
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, bit b0, bit b1, bit b2, bit b3)
            => BitVector4.FromBits(b0,b1,b2,b3);

        /// <summary>
        /// Creates a 4-bit bitvector from explicit bitss
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, bit b0, bit b1, bit b2)
            => BitVector4.FromBits(b0,b1,b2);

        /// <summary>
        /// Creates a 4-bit bitvector from explicit bitss
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, bit b0, bit b1)
            => BitVector4.FromBits(b0,b1);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, BitString src)
            => src.TakeUInt8();

        /// <summary>
        /// Creates an 8-bit bitvector from 4 explicit bits
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, bit b0, bit b1, bit b2, bit b3)
            => (byte)Bits.pack(b0, b1, b2, b3);

        /// <summary>
        /// Creates an 8-bit bitvector from 8 explicit bits
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, bit b0, bit b1, bit b2, bit b3, bit b4, bit b5, bit b6, bit b7)
            => (byte)Bits.pack(b0, b1, b2, b3, b4, b5, b6, b7);

        /// <summary>
        /// Creates an 8-bit bitvector from a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, byte src)
            => new BitVector8(src);

        /// <summary>
        /// Creates an 8-bit bitvector from the least 4 bits of an integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, int src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates an 8-bit bitvector from the least 4 bits of an unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, uint src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from the least 8 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, ulong src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector16 from(N16 n, BitString src)
            => src.TakeUInt16();

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector32 from(N32 n, BitString src)
            => src.TakeUInt32();

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, byte src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, ushort src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, uint src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, ulong src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, uint lo, uint hi)
            => from(n,(ulong)hi << 32 | (ulong)lo);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, BitString src)
            => src.TakeUInt64();

        /// <summary>
        /// Creates a generic bitvector of natural length from a single cell
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="n">The bitvector length</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> from<N,T>(T src, N n = default)        
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitVector<N,T>.FromCell(src);
    }

}