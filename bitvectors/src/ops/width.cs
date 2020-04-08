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
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int width(BitVector4 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int width(BitVector8 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int width(BitVector16 x)
            => x.Width - nlz(x);

        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int width(BitVector64 x)
            => x.Width - nlz(x);
 
        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static int width<T>(BitVector<T> x)
            where T : unmanaged
                => bitsize<T>() - nlz(x);
    }
}