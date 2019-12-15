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
        /// Creates the vector's bitstring representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector4 src)
            => BitVector.bitstring(src);

        /// <summary>
        /// Creates the vector's bitstring representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector8 src)
            => BitVector.bitstring(src);

        /// <summary>
        /// Creates the vector's bitstring representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector16 src)
            => BitVector.bitstring(src);

        /// <summary>
        /// Creates the vector's bitstring representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector24 src)
             => BitVector.bitstring(src);

        /// <summary>
        /// Creates the vector's bitstring representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector32 src)
             => BitVector.bitstring(src);

        /// <summary>
        /// Creates the vector's bitstring representation
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector64 x)
            => BitVector.bitstring(x);

        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<N,T>(this BitVector128<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitString.load(src.data, src.Width);       

        /// <summary>
        /// Converts the vector content to a bitring representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<N,T>(this BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.bitstring(x);

        /// <summary>
        /// Converts the vector content to a bitring representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<N,T>(this BitVector<N,T> x, byte[] storage)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.bitstring(x,storage);

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitVector<T> src)
            where T : unmanaged
                => BitVector.bitstring(src);

        /// <summary>
        /// Extracts the represented data as a bitstring truncated to a specified width
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitVector<T> src, int width)
            where T : unmanaged
                => BitVector.bitstring(src,width);

        /// <summary>
        /// Constructs a 4-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector(this BitString src, N4 n)
            => BitVector.from(n,src);

        /// <summary>
        /// Creates an 8-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this BitString src, N8 n)
            => BitVector.from(n,src);

        /// <summary>
        /// Creates a 16-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this BitString src, N16 n)
            => src.TakeUInt16();

        /// <summary>
        /// Creates a 24-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector24 ToBitVector(this BitString src, N24 n)
        {
            var lo = src.Slice(0,16).TakeUInt16();
            var hi = src.Slice(16,8).TakeUInt8();
            return new BitVector24(lo,hi);
        }

        /// <summary>
        /// Creates a 32-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this BitString src, N32 n)
            => BitVector.from(n, src); 

        /// <summary>
        /// Creates a 64-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this BitString src, N64 n)
            => BitVector.from(n,src);

        /// <summary>
        /// Constructs a generic bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this BitString src)
            where T : unmanaged
                => BitVector.generic<T>(src);

        [MethodImpl(Inline)]
        public static BitVector<N,T> ToBitVector<N,T>(this BitString src, N n = default, T t =default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.natural<N,T>(src);
    }
}