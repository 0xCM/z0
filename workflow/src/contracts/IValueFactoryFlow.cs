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
    /// Characterizes a coordinator that manages value production
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public interface IValueFactoryFlow<S,T> : IValueFlow
        where S : struct
        where T : struct
    {
        T Flow(in S src, IValueFactoryPipe<S,T> pipe)
            => pipe.Flow(in src);
            
        IEnumerable<T> Flow(IEnumerable<S> src, IValueFactoryPipe<S,T> pipe)
        {
            foreach(var value in src)
                yield return Flow(in value, pipe);
        }
            
    }

    /// <summary>
    /// Characterizes a coordinator that manages value production
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public interface IValueFactoryFlow<P,S,T> : IValueFlow<P,S,T>
        where S : struct
        where T : struct
        where P : IValueFactoryPipe<S,T>        
    {
        T Flow(in S src, P pipe)
            => pipe.Flow(in src);

        IEnumerable<T> IValueFlow<P,S,T>.Flow(IEnumerable<S> src, P dst)
            => dst.Flow(src);
            
        IEnumerable<T> Flow(IEnumerable<S> src, IValueFactoryPipe<S,T> pipe)
            => pipe.Flow(src);
    }
}