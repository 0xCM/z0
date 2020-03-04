//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    
    /// <summary>
    /// Identifies a source of random data
    /// </summary>
    public interface IRngSource
    {
        /// <summary>
        /// Identifies the rng that drives the source
        /// </summary>
        RngKind RngKind {get;}
    }

    public interface IRngPointSource<T> : IRngSource, IValueSource<T>
        where T : struct
    {
    
    }

    /// <summary>
    /// Characterizes a random source that can produce points bounded by a range
    /// </summary>
    /// <typeparam name="T">The primal type</typeparam>
    public interface IRngBoundPointSource<T> : IRngPointSource<T>, IBoundValueSource<T>
        where T : struct
    {
    }

    public interface IRngPointStreamSource<T> : IRngPointSource<T>, IValueStreamSource<T>
        where T : struct
    {        
    
    }


   public interface IRngSampler<T> : IRngStream<T>
        where T : struct
    {
        /// <summary>
        /// The length of the sampler's internal buffer
        /// </summary>
        int BufferLength {get;}

        /// <summary>
        /// The type of distibution being sampled
        /// </summary>
        DistKind DistKind{get;}
    }



}