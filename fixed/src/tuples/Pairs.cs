//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;
    using System.Collections;

    public static class Pairs
    {
        /// <summary>
        /// Concretizes, but does not enumerate, a heterogenous pair sequence
        /// </summary>
        /// <param name="src">The source pairs</param>
        /// <typeparam name="T0">The first member type</typeparam>
        /// <typeparam name="T1">The second member type</typeparam>
        public static Pairs<T0,T1> Define<T0,T1>(IEnumerable<Pair<T0, T1>> src)
            => new Pairs<T0,T1>(src);

        /// <summary>
        /// Concretizes, but does not enumerate, a heterogenous pair sequence
        /// </summary>
        /// <param name="src">The source pairs</param>
        /// <typeparam name="T0">The first member type</typeparam>
        /// <typeparam name="T1">The second member type</typeparam>
        public static Pairs<T0,T1> Define<T0,T1>(IEnumerable<(T0,T1)> src)
            => new Pairs<T0,T1>(from item in src select new Pair<T0,T1>(item.Item1, item.Item2));
    }

    /// <summary>
    /// Concretizes a heterogenous pair sequence
    /// </summary>
    public readonly struct Pairs<T0,T1> : IEnumerable<Pair<T0, T1>>
    {
        public Pairs(IEnumerable<Pair<T0, T1>> pairs)
            => this.pairs = pairs;

        readonly IEnumerable<Pair<T0, T1>> pairs;

        public IEnumerator<Pair<T0, T1>> GetEnumerator()
            => pairs.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            =>pairs.GetEnumerator();
    }

}