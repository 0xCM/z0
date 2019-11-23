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
        public static uint ntz<T>(in BitVector<T> x)
            where T : unmanaged
                => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint ntz(BitVector8 x)
            => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint ntz(BitVector16 x)
            => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint nlz(BitVector32 x)
            => gbits.nlz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint ntz(BitVector32 x)
            => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint ntz(BitVector64 x)
            => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zeros
        /// </summary>
        [MethodImpl(Inline)]
        public static uint ntz(in BitVector128 x)
        {
            if(x.x0 == 0)
                return gbits.ntz(x.x1) + 64;
            else
                return gbits.ntz(x.x0);
        }
    }
}