//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    partial struct root
    {
        /// <summary>
        /// Joins two arrays to form an array of pairs
        /// </summary>
        /// <typeparam name="A">The item type of the first sequence</typeparam>
        /// <typeparam name="X2">The item type of the second sequence</typeparam>
        /// <param name="s1">The first input sequence</param>
        /// <param name="s2">The second input sequence</param>
        public static Paired<A,B>[] zip<A,B>(A[] s1, B[] s2)
            => array(s1.Zip(s2, (a, b) => paired(a, b)));

        /// <summary>
        /// Joins two arrays to form a third as determined by a caller-supplied projector
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="f"></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="B"></typeparam>
        /// <typeparam name="C"></typeparam>
        public static C[] zip<A,B,C>(A[] s1, B[] s2, Func<A,B,C> f)
            => array(s1.Zip(s2, (a, b) => f(a, b)));
    }
}