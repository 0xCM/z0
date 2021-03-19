//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitVector
    {
        /// <summary>
        /// Converts the vector to a bitstring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector4 x)
            => BitString.scalar(x.Data, x.Width);

        /// <summary>
        /// Converts the vector to a bitstring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector8 x)
            => BitString.scalar(x.Data);

        /// <summary>
        /// Converts the vector to a bitstring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector16 x)
            => BitString.scalar(x.Data);

        /// <summary>
        /// Converts the vector to a bitstring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector24 x)
            => BitString.scalar(x.Data,24);

        /// <summary>
        /// Converts the vector to a bitstring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector32 x)
            => BitString.scalar(x.Data);

        /// <summary>
        /// Converts the vector to a bitstring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitString bitstring(BitVector64 x)
            => BitString.scalar(x.Data);
    }
}