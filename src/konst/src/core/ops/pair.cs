//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {            
        /// <summary>
        /// Creates an homogenous pair
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pair<T> pair<T>(T a, T b)
            => new Pair<T>(a,b);
    }
}