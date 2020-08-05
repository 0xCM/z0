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
        WfEventId Id {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfEvent<F> : IWfEvent, IAppEvent<F>
        where F : struct, IWfEvent<F>
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfEvent<F,T> : IWfEvent<F>
        where F : struct, IWfEvent<F,T>
    {
        T Body {get;}
    }
}