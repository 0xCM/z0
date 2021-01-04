//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class math
    {
        [MethodImpl(Inline), Op]
        public static ModN modn(uint n)
            => new ModN(n);

        /// <summary>
        /// Computes a % N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline), Op]
        public static uint mod(in ModN n, uint a)
            => n.mod(a);

        /// <summary>
        /// Computes the quotient a / N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline), Op]
        public static uint div(in ModN n, uint a)
            => n.div(a);

        /// <summary>
        /// Computes whether a % n == 0
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline), Op]
        public static bool divisible(in ModN n, uint a)
            => n.divisible(a);

        [MethodImpl(Inline), Op]
        public static ConstPair<uint> divrem(in ModN n, uint a)
            => n.divrem(n,a, out var dst);

        [MethodImpl(Inline), Op]
        public static uint add(in ModN n, uint a, uint b)
            => n.add(a,b);

        [MethodImpl(Inline), Op]
        public static uint mul(in ModN n, uint a, uint b)
            => n.mod(a * b);
    }


}