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