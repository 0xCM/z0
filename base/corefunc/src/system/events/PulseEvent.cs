//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    public enum CommonEventKinds : ulong
    {
        PulseEvent = 10,
    }

    /// <summary>
    /// Represents a pulse/tick/heartbeat relative to some frequency
    /// </summary>
    public readonly struct PulseEvent
    {
        public const CommonEventKinds Kind = CommonEventKinds.PulseEvent;

    
        public static PulseEvent Define(uint ServerId, uint AgentId, ulong Timestamp)
            => new PulseEvent(new EventIdentity(ServerId, AgentId, Timestamp, (ulong)Kind));

        PulseEvent(EventIdentity Identity)
        {
            this.Identity = Identity;
        }

        public readonly EventIdentity Identity;
    }
}