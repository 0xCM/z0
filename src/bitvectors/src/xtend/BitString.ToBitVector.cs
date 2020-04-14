//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
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
        public static BitVector<N,T> ToBitVector<N,T>(this BitString src, N n = default, T t =default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.natural<N,T>(src);

        [MethodImpl(Inline)]
        public static BitVector128<N,T> ToBitVector<N,T>(this BitString src, N128 n, T t = default)
            where T : unmanaged   
            where N : unmanaged, ITypeNat
                => Blocks.safeload(n,src.Pack().As<byte, T>()).LoadVector();

        /// <summary>
        /// Constructs a 4-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 ToBitVector(this BitString src, N4 n)
            => BitVector.create(n,src);

        /// <summary>
        /// Creates an 8-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this BitString src, N8 n)
            => BitVector.create(n,src);

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
            => BitVector.create(n, src); 

        /// <summary>
        /// Creates a 64-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this BitString src, N64 n)
            => BitVector.create(n,src);
    }
}