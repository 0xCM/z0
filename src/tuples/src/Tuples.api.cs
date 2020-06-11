//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public static partial class Tuples
    {        
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;        

        /// <summary>
        /// Allocates an homogenous pair store
        /// </summary>
        /// <param name="count">The store capacity</param>
        /// <typeparam name="T">The member type</typeparam>
        public static Pairs<T> pairs<T>(int count)
            where T : unmanaged
                => new Pairs<T>(new Pair<T>[count]);

        /// <summary>
        /// Allocates an homogenous triplestore
        /// </summary>
        /// <param name="count">The store capacity</param>
        /// <typeparam name="T">The member type</typeparam>
        public static Triples<T> triples<T>(int count)
            where T : unmanaged
                => new Triples<T>(new Triple<T>[count]);

        /// <summary>
        /// Creates an homogenous pair
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<T> pair<T>(T a, T b)
            => new Pair<T>(a,b);

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
        /// Creates an homogenous triple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <param name="c">The third member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Triple<T> triple<T>(T a = default, T b = default, T c = default)
            => new Triple<T>(a,b,c);

        /// <summary>
        /// Creates a non-homogenous triple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <param name="c">The third member</param>
        /// <typeparam name="T0">The first member type</typeparam>
        /// <typeparam name="T1">The second member type</typeparam>
        /// <typeparam name="T2">The third member type</typeparam>
        [MethodImpl(Inline)]
        public static Tripled<T0,T1,T2> tripled<T0,T1,T2>(T0 a = default, T1 b = default, T2 c = default)
            => new Tripled<T0,T1,T2>(a,b,c);

        /// <summary>
        /// Creates an immutable homogenous 2-tuple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> constant<T>(T a, T b)
            => new ConstPair<T>(a,b);

        /// <summary>
        /// Creates an immutable homogenous 2-tuple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<T> constant<T>(T a, T b, T c)
            => new ConstTriple<T>(a,b,c);

        /// <summary>
        /// Creates an immutable homogenous 4-tuple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <param name="c">The third member</param>
        /// <param name="d">The fourth member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> constant<T>(T a, T b, T c, T d)
            => new ConstQuad<T>(a,b,c,d);

        [MethodImpl(Inline)]
        public static Pairs<T> index<T>(Pair<T>[] src)
            where T : unmanaged
                => src;

        [MethodImpl(Inline)]
        public static Triples<T> index<T>(Triple<T>[] src)
            where T : unmanaged
                => src;
    }

    public static partial class XTend
    {
    }
}