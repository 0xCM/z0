//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitVector
    {
        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Nlz, Closures(UnsignedInts)]
        public static T ntz<T>(in BitVector<T> x)
            where T : unmanaged
                => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static T ntz<N,T>(in BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zeros
        /// </summary>
        [MethodImpl(Inline)]
        public static T ntz<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var lo = x.Lo;
            if(lo != 0)
                return As.generic<T>(gbits.ntz(lo.Data));
            else
                return As.generic<T>(gmath.add(gbits.ntz(x.Hi.Data), 64ul));
        }

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Ntz]
        public static byte ntz(BitVector8 x)
            => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Ntz]
        public static ushort ntz(BitVector16 x)
            => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Ntz]
        public static uint ntz(BitVector32 x)
            => gbits.ntz(x.Data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Ntz]
        public static ulong ntz(BitVector64 x)
            => gbits.ntz(x.Data);
    }
}