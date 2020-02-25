//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    public interface IPointSource<T>
        where T : struct
    {
        /// <summary>
        /// Retrieves the next point from the source
        /// </summary>
        T Next();            
    }    
    public interface IBoundPointSource<T> : IPointSource<T>
        where T : struct
    {
        /// <summary>
        /// Retrieves the next point from the source, constrained by an upper bound
        /// </summary>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next(T max);    
        
        /// <summary>
        /// Retrieves the next point from the source, constrained by upper and lower bounds
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive max value</param>
        T Next(T min, T max);        
    }

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
        /// Retrieves the next point from the source, bound within a specified interval
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(Interval<T> domain)
            where T : unmanaged;
    }    

    public interface IPointStream<T> : IEnumerable<T>, IPointSource<T>
        where T : struct
    {
        /// <summary>
        /// Retrieves a specified number points from the source
        /// </summary>
        /// <param name="count">The number of elements</param>
        IEnumerable<T> Next(int count);
    }

    public interface IPointStreamSource<T> : IPointSource<T>
        where T : struct
    {
        IEnumerable<T> Stream {get;}
        
    }
}