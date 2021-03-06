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
        EventId EventId {get;}

        WfStepId StepId
            => WfStepId.Empty;
    }
}