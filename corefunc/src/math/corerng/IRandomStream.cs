//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    /// <summary>
    /// Characterizes a stream of random values of parametric type
    /// </summary>
    /// <typeparam name="T">The random value type</typeparam>
    public interface IRandomStream<T> : IPointSource<T>, IEnumerable<T>
        where T : struct
    {
        /// <summary>
        /// Retrieves a specified number points from the source
        /// </summary>
        /// <param name="count">The number of elements</param>
        IEnumerable<T> Next(int count);
    }

}