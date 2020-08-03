//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IWfEvent : IAppEvent
    {
        WfEventId Id {get;}

        CorrelationToken ICorrelated.Ct 
            => Id.Ct;
    }

    public interface IWfEvent<F> : IWfEvent, IAppEvent<F>
        where F : struct, IWfEvent<F>
    {

    }

    public interface IWfEvent<F,T> : IWfEvent<F>
        where F : struct, IWfEvent<F,T>
    {
        T Payload {get;}
    }
}