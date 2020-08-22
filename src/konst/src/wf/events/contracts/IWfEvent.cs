//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IWfEvent : IAppEvent
    {
        WfEventId EventId {get;}

        string EventName => EventId.Name;

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfEvent<H> : IWfEvent, IAppEvent<H>
        where H : struct, IWfEvent<H>
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfEvent<H,T> : IWfEvent<H>
        where H : struct, IWfEvent<H,T>
    {
        T Body {get;}
    }
}