//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct root
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Triple<T> triple<T>(T a, T b, T c)
            => Tuples.triple(a,b,c);

        /// <summary>
        /// Creates a non-homogenous triple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <param name="c">The third member</param>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        /// <typeparam name="C">The third member type</typeparam>
        [MethodImpl(Inline)]
        public static Tripled<A,B,C> tripled<A,B,C>(A a, B b, C c)
            => new Tripled<A,B,C>(a,b,c);
    }
}