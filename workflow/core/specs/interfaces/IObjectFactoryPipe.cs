//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    /// <summary>
    /// Characterizes a conduit that accepts S-values and produces T-values
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The target value type</typeparam>
    public interface IObjectFactoryPipe<S,T> : IObjectPipe<S,T>
        where S : class
        where T : class
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
}