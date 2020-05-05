//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    [ApiHost]
    public class Pairs : IApiHost<Pairs>
    {
        /// <summary>
        /// Creates an homogenous pair
        /// </summary>
        /// <param name="left">The left member</param>
        /// <param name="right">The right member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<T> pair<T>(T left, T right)
            => Tuples.pair(left,right);

        /// <summary>
        /// Creates a non-homogenous pair
        /// </summary>
        /// <param name="left">The left member</param>
        /// <param name="right">The right member</param>
        /// <typeparam name="L">The first member type</typeparam>
        /// <typeparam name="R">The second member type</typeparam>
        public static Paired<L,R> paired<L,R>(L left, R right)
            => Tuples.paired(left,right);

        /// <summary>
        /// Creates an immutable homogenous 2-tuple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> constant<T>(T a, T b)
            => Tuples.constant(a,b);

        /// <summary>
        /// Creates a pair index from an array of pairs
        /// </summary>
        /// <param name="src">The source pairs</param>
        /// <typeparam name="T">The paired element type</typeparam>
        [MethodImpl(Inline)]
        public static Pairs<T> index<T>(Pair<T>[] src)
            where T : unmanaged
                => src;
    }
}