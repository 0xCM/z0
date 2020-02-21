//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Uniquely identifies an agent throughout a server complex
    /// </summary>
    
    public readonly struct AgentIdentity
    {
        /// <summary>
        /// Uniquely identifies a server
        /// </summary>
        public readonly uint ServerId;

        /// <summary>
        /// Identifies an agent relative to a server
        /// </summary>
        public readonly uint AgentId;

        /// <summary>
        /// Uniquely identifies an agent by composing the host on which it resides
        /// and the host-relative identifier
        /// </summary>
        public readonly ulong Identifier
        {
            [MethodImpl(Inline)]
            get => ((ulong)ServerId << 32) | AgentId;
        }

        /// <summary>
        /// Constructs an identity from server and agent id's
        /// </summary>
        /// <param name="loc">The location of occurence</param>
        /// <param name="time">The time of occurrence</param>
        [MethodImpl(Inline)]
        public static implicit operator AgentIdentity((uint server, uint agent) src)
            => new AgentIdentity(src.server,src.agent);
        
        [MethodImpl(Inline)]
        public static implicit operator ulong(AgentIdentity identity)
            => identity.Identifier;

        [MethodImpl(Inline)]
        public AgentIdentity(uint ServerId, uint AgentId)
        {
            this.ServerId = ServerId;
            this.AgentId = AgentId;
        }

        [MethodImpl(Inline)]
        public AgentIdentity(ulong Identifier)
        {
            this.ServerId = (uint)(Identifier >> 32);
            this.AgentId = (uint)(Identifier);
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out uint server, out uint agent)
        {
            server = ServerId;
            agent = AgentId;
        }    

        public override string ToString()
            => $"{ServerId}/{AgentId}";
    }
}