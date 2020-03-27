//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Memories;

    /// <summary>
    /// Characterizes a fountain of generic points
    /// </summary>
    public interface IPolySource
    {
        /// <summary>
        /// Retrieves the next point from the source, bound only by the domain of the type
        /// </summary>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>()
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next point from the source, constrained by an upper bounds
        /// </summary>
        /// <param name="max">The exclusive max value</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(T max)
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next point from the source, constrained by upper and lower bounds
        /// </summary>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(T min, T max)
            where T : unmanaged;

        /// <summary>
        /// Returns the default domain used when producing random points for a parametrically-identifed type
        /// </summary>
        /// <typeparam name="T">The point type</typeparam>
        Interval<T> Domain<T>()
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next point from the source, bound within a specified interval
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        T Next<T>(Interval<T> domain)
            where T : unmanaged
                => Next(domain.Left, domain.Right);
    }    
}