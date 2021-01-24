//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class BitVector
    {
        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline), Nlz, Closures(Closure)]
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
                return generic<T>(gbits.ntz(lo.Data));
            else
                return generic<T>(gmath.add(gbits.ntz(x.Hi.Data), 64ul));
        }
    }
}