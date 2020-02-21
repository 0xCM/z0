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

    public interface IValueObserverFlow<T> : IValueFlow<T>
        where T : struct
    {
        IEnumerable<T> Flow(IEnumerable<T> src, IValueObserverPipe<T> pipe)
        {
            foreach(var value in src)
                yield return pipe.Flow(in value);
        }

        IEnumerable<T> Flow(IValueSource<T> src, IValueObserverPipe<T> pipe)
            => Flow(src.Emitter(),pipe);

        IEnumerable<T> IValueFlow<T>.Flow(IEnumerable<T> src, IValuePipe<T> pipe)
            => Flow(src, pipe as IValueObserverPipe<T>);
    }

    public interface IValueObserverFlow<P,T> : IValueObserverFlow<T>, IValueFlow<P,T>
        where T : struct
        where P : IValueObserverPipe<T>
    {
        ref readonly T Flow(in T src, P pipe)
            => ref pipe.Flow(src);

        IEnumerable<T> IValueFlow<P,T>.Flow(IEnumerable<T> src, P pipe)
            => from item in src select pipe.Flow(item);            
    }

    readonly struct ValueObserverFlow<T> : IValueObserverFlow<T>
        where T : struct
    {


    }

    readonly struct ValueObserverFlow<P, T> : IValueObserverFlow<P, T>
        where T : struct
        where P : IValueObserverPipe<T>
    {


    }
}