//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures an instant in time with respect to a server/agent,
    /// real or simulated
    /// </summary>
    public readonly struct AgentEventOrigin
    {
        /// <summary>
        /// Uniquely identifies the logical event source
        /// </summary>
        public readonly ulong Location;

        /// <summary>
        /// The time of occurrence, expressed as number of elapsed ticks 
        /// from some fixed point in time
        /// </summary>
        public readonly ulong Timestamp;

        /// <summary>
        /// Constructs an origin from an ordered pair of location and timestamp
        /// </summary>
        /// <param name="loc">The location of occurrence</param>
        /// <param name="time">The time of occurrence</param>
        [MethodImpl(Inline)]
        public static implicit operator AgentEventOrigin((ulong loc, ulong time) src)
            => new AgentEventOrigin(src.loc,src.time);

        /// <summary>
        /// Constructs an origin from an ordered triple of server, agent and timestamp
        /// </summary>
        /// <param name="loc">The location of occurrence</param>
        /// <param name="time">The time of occurrence</param>
        [MethodImpl(Inline)]
        public static implicit operator AgentEventOrigin((uint server, uint agent, ulong time) src)
            => new AgentEventOrigin(src.server, src.agent, src.time);

        [MethodImpl(Inline)]
        public AgentEventOrigin(uint server, uint agent, ulong Time)
        {
            this.Location = ((ulong)server << 32) | agent;
            this.Timestamp = Time;
        }
    
        [MethodImpl(Inline)]
        public AgentEventOrigin(ulong Location, ulong Time)
        {
            this.Location = Location;
            this.Timestamp = Time;
        }

        /// <summary>
        /// The originating server
        /// </summary>
        public uint Server
        {
            [MethodImpl(Inline)]
            get => (uint)(Location >> 32);
        }

        /// <summary>
        /// The originating agent / application
        /// </summary>
        public uint Agent
        {
            [MethodImpl(Inline)]
            get => (uint) Location;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out ulong location, out ulong time)
        {
            location = Location;
            time = Timestamp;
        }    
    }
}