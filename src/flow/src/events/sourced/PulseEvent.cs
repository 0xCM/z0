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

        public const ulong SystemId = IntrinsicEvents.Pulse;

        public static PulseEvent create(uint server, uint agent, ulong ts)
            => new PulseEvent(new AgentEventId(server, agent, ts, SystemId));

        PulseEvent(AgentEventId id)
        {
            Identity = id;
        }
    }
}