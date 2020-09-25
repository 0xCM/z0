//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
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
    [Free]
    public interface IWfEvent<H> : IWfEvent, IAppEvent<H>
        where H : struct, IWfEvent<H>
    {

    }

    /// <summary>
    /// Characterizes a reified event with parametric content
    /// </summary>
    /// <typeparam name="H">The event type</typeparam>
    /// <typeparam name="T">The content type</typeparam>
    [Free]
    public interface IWfEvent<H,T> : IWfEvent<H>
        where H : struct, IWfEvent<H,T>
    {
        WfPayload<T> Content => default;
    }
}