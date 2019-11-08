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
    using static As;

    partial class BitVector
    {
        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<T>(BitVector<T> x)
            where T : unmanaged
                => gbits.pop(x.Data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector4 x)
            => Bits.pop(x.Scalar);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector8 x)
            => Bits.pop(x.Scalar);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector16 x)
            => Bits.pop(x.Scalar);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector32 x)
            => Bits.pop(x.Scalar);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector64 x)
            => Bits.pop(x.Scalar);
    }
}