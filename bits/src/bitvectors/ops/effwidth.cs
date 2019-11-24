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
        /// Computes the effective width of the vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static int effwidth<T>(BitVector<T> x)
            where T : unmanaged
                => bitsize<T>() - nlz(x);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int effwidth(BitVector4 x)
            => (int)(4 - nlz(x));

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int effwidth(BitVector8 x)
            => bitsize<BitVector8>() - nlz(x);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int effwidth(BitVector16 x)
            => bitsize<BitVector16>() - nlz(x);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int effwidth(BitVector64 x)
            => bitsize<BitVector64>() - nlz(x);

        /// <summary>
        /// Counts the number of leading zeros
        /// </summary>
        [MethodImpl(Inline)]
        public static int effwidth(in BitVector128 x)
            => bitsize<BitVector128>() - nlz(x);

    }

}