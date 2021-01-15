//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial class BitVector
    {
        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(BitVector4 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(BitVector8 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(BitVector16 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline), EffWidth]
        public static int effwidth(BitVector64 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), EffWidth, Closures(Closure)]
        public static int effwidth<T>(BitVector<T> x)
            where T : unmanaged
                => (int)bitwidth<T>() - nlz(x);
    }
}