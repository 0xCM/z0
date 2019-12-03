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
        /// Creates a copy of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Replicate<N,T>(this BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.inject<N,T>(src.data);

        /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Replicate<T>(this BitVector<T> src)
            where T : unmanaged
                => src.Scalar;

        /// <summary>
        /// Creates a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector8 Replicate(this BitVector8 src)
            => src.data;

        /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 Replicate(this BitVector4 src)
            => new BitVector4(src.data,true);

        [MethodImpl(Inline)]
        public static BitVector8 Replicate(this BitVector4 src, N2 n)
            => src.Concat(src);

        /// <summary>
        /// Concatenates an 8-bit vector with itself to produce a 16-bit vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The duplication factor</param>
        [MethodImpl(Inline)]
        public static BitVector16 Replicate(this BitVector8 src, N2 n)
            => src.Concat(src);

        /// <summary>
        /// Concatenates four copies of an 8-bit vector to produce a 32-bit vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The duplication factor</param>
        [MethodImpl(Inline)]
        public static BitVector32 Replicate(this BitVector8 src, N4 n)
            => src.Replicate(n2).Replicate(n2);

        /// <summary>
        /// Concatenates eight copies of an 8-bit vector to produce a 64-bit vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The duplication factor</param>
        [MethodImpl(Inline)]
        public static BitVector64 Replicate(this BitVector8 src, N8 n)
            => src.Replicate(n4).Replicate(n2);

        /// <summary>
        /// Creates a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector16 Replicate(this BitVector16 x)
            => x.data;

        /// <summary>
        /// Concatenates a 16-bit vector with itself to produce a 32-bit vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The duplication factor</param>
        [MethodImpl(Inline)]
        public static BitVector32 Replicate(this BitVector16 src, N2 n)
            => src.Concat(src);

        /// <summary>
        /// Concatenates four copies of a 16-bit vector to produce a 64-bit vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The duplication factor</param>
        [MethodImpl(Inline)]
        public static BitVector64 Replicate(this BitVector16 x, N4 n)
        {
            var y = x.Replicate(n2);
            return y.Replicate(n2);
        }

        /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 Replicate(this BitVector32 src)
            => new BitVector32(src.data);

        /// <summary>
        /// Contatenates a 32-bit vector with itself to produce a 64-bit vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 Replicate(this BitVector32 src, N2 n)
            => src.Concat(src);

        /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector64 Replicate(this BitVector64 x)
            => x.data;

        /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector128 Replicate(this BitVector128 src)
            => new BitVector128(src.x0,src.x1);
    }
}