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
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint nlz<T>(BitVector<T> x)
            where T : unmanaged
             => gbits.nlz(x.data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint nlz(BitVector8 x)
            => gbits.nlz(x.data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint nlz(BitVector16 x)
            => gbits.nlz(x.data);


        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static uint nlz(BitVector64 x)
            => gbits.nlz(x.data);

        /// <summary>
        /// Counts the number of leading zeros
        /// </summary>
        [MethodImpl(Inline)]
        public static uint nlz(in BitVector128 x)
        {
            if(x.x1 == 0)
                return 64 + gbits.nlz(x.x0);
            else
                return gbits.nlz(x.x1);
        }


    }
}