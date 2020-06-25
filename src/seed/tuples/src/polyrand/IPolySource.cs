//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes a fountain of generic points
    /// </summary>
    public interface IPolySource : IBoundValueSource, IValueSource
    {
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