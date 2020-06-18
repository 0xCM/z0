//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static CaptureWorkflowEvents;

    public interface IMembersLocatedBroker : IEventBroker
    {
        MembersLocated MembersLocated => MembersLocated.Empty;
    }

    public interface IMembersLocatedClient<C> : IBrokerClient<C>
        where C : IMembersLocatedBroker
    {
        void OnEvent(MembersLocated e) 
            => Sink.Deposit(e);
    }
}