//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes a factory where the production type is T-parametric
    /// </summary>
    /// <typeparam name="T">A type which paremetrizes the production type</typeparam>
    public interface IFactory<T>
    {

    }
        
    /// <summary>
    /// Refies a factory that produces no T-parametric values; the use case is
    /// to make it convenient to create factories that do produce values that are T-parametric
    /// </summary>
    /// <typeparam name="T">A type which paremetrizes the production type</typeparam>
    public readonly struct Factory<T> : IFactory<T> { }        
}