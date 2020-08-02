//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IWfEvent : IAppEvent
    {
        WfEventId Id {get;}

        CorrelationToken ICorrelated.Correlation 
            => Id.Correlation;
    }

    public interface IWfEvent<F> : IWfEvent, IAppEvent<F>
        where F : struct, IWfEvent<F>
    {

    }
}