//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    /// <summary>
    /// Characterizes a suite of random number generators
    /// </summary>
    /// <typeparam name="N">The number of generators in the suite</typeparam>
    public interface IRngSuite256<N>
        where N : unmanaged, ITypeNat
    {
        /// <summary>
        /// Retrieves the next vector from the suite, where the components
        /// are bound only by the domain of the type
        /// </summary>
        Block256<N,T> Next<T>()
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is
        /// constrained by an upper bound
        /// </summary>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        Block256<N,T> Next<T>(T max)
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is
        /// constrained by both lower and upper bounds
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        Block256<N,T> Next<T>(T min, T max)
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is
        /// constrained by an interval domain
        /// </summary>
        /// <param name="domain">The range</param>
        /// <typeparam name="T">The point type</typeparam>
        Block256<N,T> Next<T>(Interval<T> domain)
            where T : unmanaged;

        /// <summary>
        /// Retrieves the generator corresponding to a specified index that
        /// is in the range 0, 1, ..., N - 1
        /// </summary>
        /// <param name="index">The rng index</param>
        IPolyrand Select(int index);
    }
}