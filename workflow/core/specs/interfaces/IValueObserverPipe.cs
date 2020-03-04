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

    public interface IValueObserverPipe : IValuePipe
    {

    }

    public interface IValueObserverPipe<T> : IValueObserverPipe, IValuePipe<T>
        where T : struct
    {
        SinkReceiver<T> Receiver {get;}

        [MethodImpl(Inline)]
        ref readonly T Flow(in T src)
        {
            Receiver(src);
            return ref src;
        }

        ValueRelay<T> Relay 
            => Flow;

        IEnumerable<T> Flow(IEnumerable<T> src)
        {
            foreach(var value in src)
                yield return Flow(in value);
        }

        [MethodImpl(Inline)]
        object IPipe.Flow(object src)
            => Flow(in Unsafe.As<object,T>(ref Unsafe.AsRef(in src)));
    }
}