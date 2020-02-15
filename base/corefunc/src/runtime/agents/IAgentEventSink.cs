//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public delegate void OnAgentTransition(in AgentTransition transition);

    public interface IAgentEventSink
    {
        void Pulse(PulseEvent e);
        
        void AgentTransitioned(AgentTransition data);
    }
}