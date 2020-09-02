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

        WfStepId StepId
            => WfStepId.Empty;
    }

    /// <summary>
    /// Characterizes a reified event
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IWfEvent<H> : IWfEvent, IAppEvent<H>
        where H : struct, IWfEvent<H>
    {

    }

    /// <summary>
    /// Characterizes a reified event with parametric content
    /// </summary>
    /// <typeparam name="H">The event type</typeparam>
    /// <typeparam name="T">The content type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IWfEvent<H,T> : IWfEvent<H>
        where H : struct, IWfEvent<H,T>
    {
        WfPayload<T> Content => default;
    }
}