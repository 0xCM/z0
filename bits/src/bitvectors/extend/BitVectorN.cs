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
        /// Converts a generic bitvector to natural bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> ToNatural<N,T>(this BitVector<T> src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.natural<N,T>(src.Scalar);

        /// <summary>
        /// Converts the vector content to a bitring representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Replicate<N,T>(this BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.Scalar;

        /// <summary>
        /// Converts the vector content to a bitring representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<N,T>(this BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.bitstring(x);
        
        [MethodImpl(Inline)]
        public static BitVector<N,T> ToBitVector<N,T>(this BitString src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.natural<N,T>(src);

        /// <summary>
        /// Defines a bitvector over an 8-bit cell of specified natural width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<N,byte> ToNatBits<N>(this byte src, N n = default)
            where N : unmanaged, ITypeNat
                => src;

        /// <summary>
        /// Defines a bitvector over a 16-bit cell of specified natural width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<N,ushort> ToNatBits<N>(this ushort src, N n = default)
            where N : unmanaged, ITypeNat
                => src;

        /// <summary>
        /// Defines a bitvector over a 32-bit cell of specified natural width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<N,uint> ToNatBits<N>(this uint src, N n = default)
            where N : unmanaged, ITypeNat
                => src;

        /// <summary>
        /// Defines a bitvector over a 64-bit cell of specified natural width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<N,ulong> ToNatBits<N>(this ulong src, N n = default)
            where N : unmanaged, ITypeNat
                => src;        

        [MethodImpl(Inline)]
        public static string Format<N,T>(this BitVector<N,T> src, BitFormat? fmt = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.format(src,fmt);
    }
}