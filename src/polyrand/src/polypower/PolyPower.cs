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

    public static class PolyPower
    {
        /// <summary>
        /// Produces a random power of 2 within the primal type domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Power<T>(this IPolyStream random, T t = default)
            where T : unmanaged
                => force<ulong,T>(Z0.Pow2.pow(random.Log2(t)));

        /// <summary>
        /// Produces a random power of 2 with specified min/max exponent values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minexp">The min exponent value</param>
        /// <param name="maxexp">The max exponent value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Power<T>(this IPolyStream random, int minexp, int maxexp)
            where T : unmanaged
        {
            var exp = random.Next((byte)minexp, (byte)(maxexp + 1));
            return force<ulong,T>(Z0.Pow2.pow(exp));
        }

        /// <summary>
        /// Produces a power-of-2 exponent n (i.e. log base 2) such that 2^n < maxvalue[T];
        /// consequently, the exponentiation of the retrieved value will be confiled to
        /// the domain of the type (ignoring sign)
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static int Log2<T>(this IPolyStream random, T t = default)
            where T : unmanaged
                => random.One(0,  BitSize.measure<T>());
    }
}