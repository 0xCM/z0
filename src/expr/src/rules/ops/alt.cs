//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct rules
    {
        /// <summary>
        /// Creates a binary union
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Alt<T> alt<T>(T a, T b)
            => new Alt<T>(a,b);

        /// <summary>
        ///  Creates a heterogenous binary union
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static Alt<A,B> alt2<A,B>(A a, B b)
            => new Alt<A,B>(a,b);
    }
}