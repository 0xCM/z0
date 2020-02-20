//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using static As;

    partial class CoreRng
    {
        /// <summary>
        /// Produces a single random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Single<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => random.Next<T>();

        /// <summary>
        /// Produces an 8-bit random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static byte Single(this IPolyrand random, N8 w)
            => random.Next<byte>();

        /// <summary>
        /// Produces a 16-bit random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ushort Single(this IPolyrand random, N16 w)
            => random.Next<ushort>();

        /// <summary>
        /// Produces a 32-bit random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint Single(this IPolyrand random, N32 w)
            => random.Next<uint>();

        /// <summary>
        /// Produces a 64-bit random value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ulong Single(this IPolyrand random, N64 w)
            => random.Next<ulong>();

        /// <summary>
        /// Produces a single random value within a range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Single<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => random.Next<T>(min,max);
    }
}