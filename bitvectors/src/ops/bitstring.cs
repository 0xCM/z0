//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; using static Memories;

    partial class BitVector
    {
        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector4 x)
            => BitString.scalar(x.Scalar, x.Width);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector8 x)
            => BitString.scalar(x.Scalar);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector16 x)
            => BitString.scalar(x.Scalar);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector24 x)
            => BitString.scalar(x.Scalar,24);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector32 x)
            => BitString.scalar(x.Scalar);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector64 x)
            => BitString.scalar(x.Scalar);
        
        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline), Op]
        public static BitString bitstring<T>(BitVector<T> src)
            where T : unmanaged
                => BitString.scalar<T>(src.Scalar); 

        /// <summary>
        /// Extracts the represented data as a bitstring truncated to a specified width
        /// </summary>
        [MethodImpl(Inline), Op]
        public static BitString bitstring<T>(BitVector<T> src, int width)
            where T : unmanaged
                => BitString.scalar<T>(src.Scalar, width);
   }
}