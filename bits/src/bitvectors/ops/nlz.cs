//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static int nlz<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                =>  gbits.nlz(x.data) - x.Width;

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int nlz<N,T>(BitVector128<N,T> x, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            // if(x.x1 == 0)
            //     return 64 + gbits.nlz(x.x0);
            // else
            //     return gbits.nlz(x.x1);
            return default;
        }

    }
}