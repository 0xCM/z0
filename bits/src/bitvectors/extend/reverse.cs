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
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 Reverse(this BitVector4 src)
            => BitVector.rev(src);

        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 Reverse(this BitVector8 src)
            => BitVector.rev(src);

        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 Reverse(this BitVector16 src)
            => BitVector.rev(src);

        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 Reverse(this BitVector32 src)
            => BitVector.rev(src);

        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 Reverse(this BitVector64 src)
            => BitVector.rev(src);

        /// <summary>
        /// Reverses a copy of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Reverse<T>(this BitVector<T> src)
            where T : unmanaged
                => BitVector.rev(src);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Reverse<N,T>(this BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.rev(x);
    }
}