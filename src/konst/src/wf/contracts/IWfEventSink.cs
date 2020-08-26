//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IWfEventSink : ISink<IWfEvent>, IAppEventSink, IAppMsgSink, IDisposable
    {
        ref readonly E Deposit<E>(in E @event)
            where E : IWfEvent;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfEventSink<H> : IWfEventSink
        where H : struct, IWfEventSink<H>
    {

    }

    /// <summary>
    /// Characterizes a workflow event sink that receives T-parametric table events
    /// </summary>
    /// <typeparam name="H"></typeparam>
    /// <typeparam name="T"></typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IWfEventSink<H,T> : IWfEventSink
        where H : struct, IWfEventSink<H>
        where T : struct, ITable<T>, IWfDataEvent<T>
    {

    }
}