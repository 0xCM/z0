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

    public interface IObjectObserverFlow<T> : IObjectFlow<T>
        where T : class
    {
        IEnumerable<T>  Flow(IEnumerable<T> src, IObjectObserverPipe<T> pipe)
        {
            foreach(var value in src)
                yield return pipe.Flow(in value);
        }

        IEnumerable<T> IObjectFlow<T>.Flow(IEnumerable<T> src, IObjectPipe<T> pipe)
            => Flow(src, pipe as IObjectObserverPipe<T>);
    }

    public interface IObjectObserverFlow<P,T> : IObjectObserverFlow<T>, IObjectFlow<P,T>
        where T : class
        where P : IObjectObserverPipe<T>
    {

        ref readonly T Flow(in T src, P pipe)
            => ref pipe.Flow(src);

        IEnumerable<T> Flow(IEnumerable<T> src, P pipe)
            => from item in src select pipe.Flow(item);                        
    }
}