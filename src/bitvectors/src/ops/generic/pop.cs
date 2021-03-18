//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class BitVector
    {
        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Pop, Closures(Closure)]
        public static uint pop<T>(BitVector<T> x)
            where T : unmanaged
                => gbits.pop(x.Data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.pop(x.Data);


        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.pop(x.Data.AsUInt64().GetElement(0)) + gbits.pop(x.Data.AsUInt64().GetElement(1));

    }
}