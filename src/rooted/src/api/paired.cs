//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class Roots
    {            
        /// <summary>
        /// Creates a non-homogenous pair
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T0">The first member type</typeparam>
        /// <typeparam name="T1">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static Paired<T0,T1> paired<T0,T1>(T0 a = default, T1 b = default)
            => new Paired<T0,T1>(a,b);


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