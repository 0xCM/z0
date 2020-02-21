//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines logical event identity
    /// </summary>
    public readonly struct EventIdentity
    {
        /// <summary>
        /// Constructs an event identity from a (kind,server,agent,time) tuple
        /// </summary>
        /// <param name="loc">The location of occurence</param>
        /// <param name="time">The time of occurrence</param>
        /// <param name="kind">The kind of event that occurred</param>
        [MethodImpl(Inline)]
        public static implicit operator EventIdentity((uint server, uint agent, ulong time, ulong kind) src)
            => new EventIdentity(src.server, src.agent, src.time,src.kind);

        [MethodImpl(Inline)]
        public EventIdentity(uint ServerId, uint AgentId, ulong Timestamp, ulong Kind)
        {
            this.ServerId = ServerId;
            this.AgentId = AgentId;
            this.Timestamp = Timestamp;
            this.EventKind = Kind;
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

        /// <summary>
        /// The event classifier/discriminator
        /// </summary>        
        public readonly ulong EventKind;

        public ulong Location
        {
            [MethodImpl(Inline)]
            get => ((ulong)ServerId << 32) & AgentId; 
        }

        /// <summary>
        /// Specifies the spacetime event origin
        /// </summary>
        public EventOrigin Origin
        {
            [MethodImpl(Inline)]
            get => (Location, Timestamp);
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out ulong kind, out uint server, out uint agent, out ulong time)
        {
            kind = EventKind;
            server = ServerId;
            agent = AgentId;
            time = Timestamp;
        }

        public override string ToString() 
            => $"{EventKind}/{ServerId}/{AgentId}/{Timestamp}";
    }
}