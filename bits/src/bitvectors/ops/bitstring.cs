//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="N">The bitvector width</typeparam>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitString bitstring<N,T>(in BitVector128<N,T> x)
            where T : unmanaged   
            where N : unmanaged, ITypeNat
                => BitString.from(x.data, x.Width);

        /// <summary>
        /// Converts the vector content to a bitring representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString bitstring<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitString.from<T>(x.Scalar, x.Width);
        
        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString bitstring<T>(BitVector<T> src)
            where T : unmanaged
                => BitString.from<T>(src.Scalar); 

        /// <summary>
        /// Extracts the represented data as a bitstring truncated to a specified width
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString bitstring<T>(BitVector<T> src, int width)
            where T : unmanaged
                => BitString.from<T>(src.Scalar, width);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitString bitstring(BitVector4 x)
            => BitString.from(x.Scalar, x.Width);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitString bitstring(BitVector8 x)
            => BitString.from(x.Scalar);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitString bitstring(BitVector16 x)
            => BitString.from(x.Scalar);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitString bitstring(BitVector32 x)
            => BitString.from(x.Scalar);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitString bitstring(BitVector64 x)
            => BitString.from(x.Scalar);

        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString bitstring(BitVector128 x)
            => BitString.from(x.x1) + BitString.from(x.x0);

    }

}