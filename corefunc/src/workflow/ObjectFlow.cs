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

    using static zfunc;
    
    public interface IObjectFlow : IFlow
    {

    }

    public interface IObjectFlow<T> : IObjectFlow
        where T : class
    {
        IEnumerable<T> Flow(IEnumerable<T> src, IObjectPipe<T> pipe);

    }

    public interface IObjectFlow<P,T> : IObjectFlow<T>
        where T : class
        where P : IObjectPipe<T>
    {

    }

    public interface IObjectFlow<P,S,T>  : IObjectFlow
        where S : class
        where T : class
        where P : IObjectPipe<S,T>
    {
        
        IEnumerable<T> Flow(IEnumerable<S> src, P pipe);

     }
}