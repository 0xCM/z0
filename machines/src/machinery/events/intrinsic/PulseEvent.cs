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
        public const ulong SystemId = IntrinsicEvents.Pulse;
    
        public static PulseEvent Define(uint ServerId, uint AgentId, ulong Timestamp)
            => new PulseEvent(new EventIdentity(ServerId, AgentId, Timestamp, SystemId));

        PulseEvent(EventIdentity Identity)
        {
            this.Identity = Identity;
        }

        public EventIdentity Identity {get;}
    }
}