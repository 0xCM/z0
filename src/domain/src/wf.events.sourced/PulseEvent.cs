//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Represents a pulse/tick/heartbeat relative to some frequency
    /// </summary>
    public readonly struct PulseEvent : IServerEvent
    {
        public AgentEventId Identity {get;}

        internal PulseEvent(AgentEventId id)
        {
            Identity = id;
        }
    }
}