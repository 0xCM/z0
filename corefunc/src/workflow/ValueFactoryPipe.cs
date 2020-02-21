//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes a function that produces T-values from S-values
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public delegate T ValueProducer<S,T>(in S src)
        where S : struct        
        where T : struct;

    /// <summary>
    /// Characterizes a conduit that accepts S-values and produces T-values
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The target value type</typeparam>
    public interface IValueFactoryPipe<S,T> : IValuePipe<S,T>
        where S : struct
        where T : struct
    {
        /// <summary>
        /// Produces a target value from a source value
        /// </summary>
        /// <param name="src">The source value</param>
        T Flow(in S src);
        
        /// <summary>
        /// Transforms a stream of source values into a stream of target values
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<T> Flow(IEnumerable<S> src)
        {
            foreach(var item in src)
                yield return Flow(in item);
        }

        [MethodImpl(Inline)]
        object IPipe.Flow(object src)
            => Flow(in Unsafe.As<object,S>(ref Unsafe.AsRef(in src)));
    }

    /// <summary>
    /// Reifies a value factor pipe via a supplied production function
    /// </summary>
    readonly struct ValueFactoryPipe<S,T> : IValueFactoryPipe<S,T>
        where S : struct
        where T : struct
    {        
        readonly ValueProducer<S,T> Producer;
        
        [MethodImpl(Inline)]
        public ValueFactoryPipe(ValueProducer<S,T> producer)
            => this.Producer = producer;

        /// <summary>
        /// Transforms a source value to a target value via the producer with which the pipe was instantiated
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public T Flow(in S src)
            => Producer(in src);
    }
}