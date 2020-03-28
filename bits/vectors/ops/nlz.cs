//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;    

    partial class BitVector
    {            
        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int nlz<T>(BitVector<T> x)
            where T : unmanaged
                => gbits.nlz(x.data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int nlz(BitVector4 x)
            => gbits.nlz(x.data) - x.Width;

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int nlz(BitVector8 x)
            => gbits.nlz(x.data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int nlz(BitVector16 x)
            => gbits.nlz(x.data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int nlz(BitVector32 x)
            => gbits.nlz(x.data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int nlz(BitVector64 x)
            => gbits.nlz(x.data);
    }
}