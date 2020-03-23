//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFactory
    {
        
    }
    
    /// <summary>
    /// Characterizes a factory where the production type is T-parametric
    /// </summary>
    /// <typeparam name="T">A type which paremetrizes the production type</typeparam>
    public interface IFactory<T> : IFactory
    {

    }

    
    public interface IFactory<in S,out T> : IFactory
    {
        /// <summary>
        /// Given an S-value produces a T-value
        /// </summary>
        /// <param name="src">The source value</param>
        T Create(S src);
    }
    
    /// <summary>
    /// Refies a factory that produces no T-parametric values; the use case is
    /// to make it convenient to create factories that do produce values that are T-parametric
    /// </summary>
    /// <typeparam name="T">A type which paremetrizes the production type</typeparam>
    public readonly struct Factory<T> : IFactory<T> { }        

}