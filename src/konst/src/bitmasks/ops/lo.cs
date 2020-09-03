//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    partial class BitMask
    {           
        /// <summary>
        /// Produces a sequence of n enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline),Op]
        public static ulong lo64(int n)
            => lomask(Pow2.pow(n));

        /// <summary>
        /// Produces a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lo<T>(int n, T t = default)
            where T : unmanaged
                => convert<ulong,T>(lo64(n));

        /// <summary>
        /// Produces a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <param name="n">The bit count type representative</param>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static ulong lo<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatCalc.pow2m1<N>();

        /// <summary>
        /// Produces a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <param name="n">The number of bits to enable</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        /// <typeparam name="T">The mask type</typeparam>
        [MethodImpl(Inline)]
        public static T lo<N,T>(N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => convert<ulong,T>(lo(n));
    }
}