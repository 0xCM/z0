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

    public interface IRngPointSource<T> : IRngSource, IPointSource<T>
        where T : struct
    {
    
    }

    /// <summary>
    /// Characterizes a stream of random values of parametric type
    /// </summary>
    /// <typeparam name="T">The random value type</typeparam>
    public interface IRngStream<T> : IRngPointSource<T>, IPointStream<T> 
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

    public interface IRngPointStreamSource<T> : IRngPointSource<T>, IPointStreamSource<T>
        where T : struct
    {        
    
    }

    /// <summary>
    /// Characterizes a random source that can produce points bounded by a range
    /// </summary>
    /// <typeparam name="T">The primal type</typeparam>
    public interface IRngBoundPointSource<T> : IRngPointSource<T>, IBoundPointSource<T>
        where T : struct
    {
    }

    /// <summary>
    /// Characterizes a random stream navigator
    /// </summary>
    public interface IRngNav
    {
        /// <summary>
        /// Moves the stream a specified number of steps forward
        /// </summary>
        /// <param name="steps">The step count</param>
        void Advance(ulong steps);

        /// <summary>
        /// Moves the stream a specified number of steps backward
        /// </summary>
        /// <param name="steps">The step count</param>
        void Retreat(ulong steps);
    }

    /// <summary>
    /// Characterizes a random source that can be navigated
    /// </summary>
    /// <typeparam name="T">The primal element type</typeparam>
    public interface INavigableRng<T> : IRngNav, IRngBoundPointSource<T> 
        where T : struct
    {

    }

    /// <summary>
    /// Characterizes source capable of producing an interminable sequence of pseudorandom bounded points 
    /// of any numeric type among: sbyte, byte, short, ushort, int, uint, long, ulong, float, double
    /// </summary>
    public interface IPolyrand : IPolySource,
        IRngBoundPointSource<sbyte>,
        IRngBoundPointSource<byte>,
        IRngBoundPointSource<short>,
        IRngBoundPointSource<ushort>,
        IRngBoundPointSource<int>, 
        IRngBoundPointSource<uint>, 
        IRngBoundPointSource<long>,
        IRngBoundPointSource<ulong>, 
        IRngBoundPointSource<float>,
        IRngBoundPointSource<double> 
    {
        /// <summary>
        /// Retrieves the random stream navigator, if supported
        /// </summary>
        Option<IRngNav> Navigator {get;}    
    } 

    /// <summary>
    /// Characterizes a type that provides access to a stateful and parametric-polymorphic 
    /// pseudorandom number generator
    /// </summary>
    public interface IRngProvider
    {
        /// <summary>
        /// The provided random number generator
        /// </summary>
        IPolyrand Random {get;}
        
    }
    
    /// <summary>
    /// A context that carries an RNG state
    /// </summary>
    public interface IRngContext : IRngProvider, IContext
    {   
           
    }
}