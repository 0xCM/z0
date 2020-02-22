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
    public interface IObjectFactoryFlow<P,S,T> : IObjectFlow<P,S,T>
        where S : class
        where T : class
        where P : IObjectFactoryPipe<S,T>        
    {
        T Flow(in S src, P pipe)
            => pipe.Flow(in src);

        IEnumerable<T> IObjectFlow<P,S,T>.Flow(IEnumerable<S> src, P dst)
            => dst.Flow(src);
            
        IEnumerable<T> Flow(IEnumerable<S> src, IObjectFactoryPipe<S,T> pipe)
            => pipe.Flow(src);
    }

}