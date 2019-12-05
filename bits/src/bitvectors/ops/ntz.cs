//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz<T>(in BitVector<T> x)
            where T : unmanaged
                => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz<N,T>(in BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz(BitVector8 x)
            => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz(BitVector16 x)
            => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz(BitVector32 x)
            => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz(BitVector64 x)
            => gbits.ntz(x.data);

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
    }
}