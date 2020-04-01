//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAppEventSink : ISink
    {

    }

    public interface IAppEventSink<E> : IAppEventSink, ISink<E>
        where E : IAppEvent
    {

    }

    public interface IAppEventSink<S,E> : IAppEventSink<E>
        where S : IAppEventSink<S,E>
        where E : IAppEvent
    {

        
    }
}