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

    public interface IObjectObserverPipe<T> : IObjectPipe<T>
        where T : class
    {
        ObjectReceiver<T> Receiver {get;}

        [MethodImpl(Inline)]
        ref readonly T Flow(in T src)
        {
            Receiver(src);
            return ref src;
        }

        ObjectRelay<T> Relay 
            => Flow;

        IEnumerable<T> Flow(IEnumerable<T> src)
        {
            foreach(var value in src)
                yield return Flow(in value);
        }

        object IPipe.Flow(object src)
            => Flow(Unsafe.As<object,T>(ref Unsafe.AsRef(in src)));
    }
}