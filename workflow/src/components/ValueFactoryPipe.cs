//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Reifies a value factor pipe via a supplied production function
    /// </summary>
    readonly struct ValueFactoryPipe<S,T> : IValueFactoryPipe<S,T>
        where S : struct
        where T : struct
    {        
        readonly ValueTransformer<S,T> Producer;
        
        [MethodImpl(Inline)]
        public ValueFactoryPipe(ValueTransformer<S,T> producer)
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