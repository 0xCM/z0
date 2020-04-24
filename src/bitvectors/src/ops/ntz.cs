//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class BitVector
    {
        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Nlz, Closures(UnsignedInts)]
        public static int ntz<T>(in BitVector<T> x)
            where T : unmanaged
                => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz<N,T>(in BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zeros
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var lo = x.Lo;
            if(lo != 0)
                return gbits.ntz(lo);
            else
                return gbits.ntz(x.Hi) + 64;
        }

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Ntz]
        public static int ntz(BitVector8 x)
            => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Ntz]
        public static int ntz(BitVector16 x)
            => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Ntz]
        public static int ntz(BitVector32 x)
            => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Ntz]
        public static int ntz(BitVector64 x)
            => gbits.ntz(x.Data);
    }
}