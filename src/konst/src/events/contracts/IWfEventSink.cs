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
    public interface IWfEventSink<F> : IWfEventSink
        where F : struct, IWfEventSink<F>
    {

    }
}