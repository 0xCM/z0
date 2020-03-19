//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public delegate IAppEvent AppEventEmitter();

    public delegate E AppEventEmitter<E>()
        where E : IAppEvent;        

    public interface IAppEventSource : ISource
    {

    }

    public interface IAppEventSource<E> : IAppEventSource
        where E : IAppEvent
    {
        void AcceptReceiver(Action<E> receiver);
    }

    public interface IAppEventSource<S,E> : IAppEventSource<E>
        where S : IAppEventSource<S,E>
        where E : IAppEvent
    {
        
    }
}