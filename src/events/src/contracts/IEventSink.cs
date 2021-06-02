//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IEventSink<E> : ISink<E>
        where E : IWfEvent
    {

    }

    [Free]
    public interface IEventSink : IEventSink<IWfEvent>, IDisposable
    {

    }

    public readonly struct DevNull : IEventSink
    {
        public static IEventSink BlackHole => default(DevNull);

        public void Deposit(IWfEvent src){ }

        public void Dispose(){ }
    }

    [Free]
    public interface IEventEmitter : IEmitter<IWfEvent>
    {

    }


    [Free]
    public interface IEmissionSink : IEventSink, IDisposable
    {

    }

    [Free]
    public interface IEmissionSink<S> : IEmissionSink
        where S : IEmissionSink<S>
    {

    }
}