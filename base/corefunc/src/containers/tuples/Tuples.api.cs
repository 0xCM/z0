//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines api surface for pair
    /// </summary>
    public static class Tuples
    {        
        /// <summary>
        /// Creates an homogenous, empty, mutable 2-tuple
        /// </summary>
        /// <param name="t">A member type representative</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<T> alloc<T>(T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Creates a non-homogenous, empty, mutable 2-tuple
        /// </summary>
        /// <typeparam name="L">The left member type</typeparam>
        /// <typeparam name="R">The right member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<L,R> alloc<L,R>(L tl = default, R tr = default)
            where L : unmanaged
            where R : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Triple<T> alloc<T>(N3 n, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Creates an homogenous, empty, mutable 3-tuple
        /// </summary>
        /// <param name="n">The tuple arity selector</param>
        /// <param name="b">A member type representative</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Triple<T> alloc<T>()
            where T : unmanaged
                => default;

        /// <summary>
        /// Creates a non-homogenous, empty, mutable 3-tuple
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Triple<X,Y,Z> alloc<X,Y,Z>(X tx = default, Y ty = default, Z tz = default)
            where X: unmanaged
            where Y : unmanaged
            where Z : unmanaged
                => default;

        /// <summary>
        /// Creates an homogenous, non-empty, mutable 2-tuple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<T> init<T>(T a, T b)
            where T : unmanaged
                => new Pair<T>(a,b);

        /// <summary>
        /// Creates a non-homogenous, non-empty, mutable 2-tuple
        /// </summary>
        /// <param name="l">The first member</param>
        /// <param name="r">The second member</param>
        /// <typeparam name="L">The first member type</typeparam>
        /// <typeparam name="R">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<L,R> init<L,R>(L l, R r)
            where L : unmanaged
            where R : unmanaged
                => new Pair<L,R>(l,r);

        /// <summary>
        /// Creates an homogenous, non-empty, mutable 3-tuple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Triple<T> init<T>(T a, T b, T c)
            where T : unmanaged
                => new Triple<T>(a,b,c);

        /// <summary>
        ///  Creates a non-homogenous, non-empty, mutable 3-tuple
        /// </summary>
        /// <param name="x">The first member</param>
        /// <param name="y">The second member</param>
        /// <param name="z">The third member</param>
        /// <typeparam name="X">The first member type</typeparam>
        /// <typeparam name="Y">The second member type</typeparam>
        /// <typeparam name="Z">The third member type</typeparam>
        [MethodImpl(Inline)]
        public static Triple<X,Y,Z> init<X,Y,Z>(X x, Y y, Z z)
            where X: unmanaged
            where Y : unmanaged
            where Z : unmanaged
                => new Triple<X, Y, Z>(x,y,z);

        /// <summary>
        /// Creates an immutable 2-tuple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> constant<T>(T a, T b)
            where T : unmanaged
                =>  new ConstPair<T>(a,b);

        /// <summary>
        /// Creates an immutable 4-tuple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <param name="c">The third member</param>
        /// <param name="d">The fourth member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> constant<T>(T a, T b, T c, T d)
            where T : unmanaged
                =>  new ConstQuad<T>(a,b,c,d);
    }
}