//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IEventSink : ISink<IWfEvent>, IDisposable
    {

    }

    [Free]
    public interface IEventSink<E> : ISink<E>
        where E : IWfEvent<E>, new()
    {

    }

    [Free]
    public interface IEventEmitter : IDisposable
    {
        ReadOnlySpan<IWfEvent> Emit();
    }

    [Free]
    public interface IEventEmitter<E>
        where E : IWfEvent, new()
    {
        ReadOnlySpan<E> Emit();
    }

    public interface IEmissionSink : IEventSink, IEventEmitter
    {

    }

    public interface IEmissionSink<S> : IEmissionSink
        where S : IEmissionSink<S>
    {

    }
}