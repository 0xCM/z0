//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class Tuples
    {
        /// <summary>
        /// Creates an homogenous pair
        /// </summary>
        /// <param name="left">The left member</param>
        /// <param name="right">The right member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pair<T> pair<T>(T left, T right)
            => new Pair<T>(left,right);

        /// <summary>
        /// Creates an immutable homogenous 2-tuple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstPair<T> pair<T>(T a, T b, bool constant)
            => new ConstPair<T>(a,b);

    }
}