//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Captures an instant in time with respect to a server/agent
    /// </summary>
    public readonly struct Heartbeat
    {
        public static implicit operator Heartbeat((uint server, uint agent, ulong time) src)
            => new Heartbeat(src.server, src.agent, src.time);

        public Heartbeat(uint ServerId, uint AgentId, ulong Timestamp)
            : this()
        {
            this.ServerId = ServerId;
            this.AgentId = AgentId;
            this.Timestamp = Timestamp;
        }

        /// <summary>
        /// The originating server
        /// </summary>
        public readonly uint ServerId;

        /// <summary>
        /// The originating agent
        /// </summary>
        public readonly uint AgentId;

        /// <summary>
        /// Represents the time at which the event originated
        /// </summary>
        public readonly ulong Timestamp;

        public EventOrigin Origin
            => (ServerId, AgentId, Timestamp);


        public override string ToString() 
            => $"({ServerId},{AgentId},{Timestamp})";
    }

}