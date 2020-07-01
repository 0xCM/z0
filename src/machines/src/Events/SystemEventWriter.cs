//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics.Tracing;

    [EventSource(Name = SourceName)]    
    public sealed class SystemEventWriter : EventWriter, IPulseEventReceiver
    {
        public const string SourceName = "zsyn/system-events";

        public static readonly IAgentEventSink Log = new SystemEventWriter();
                
        SystemEventWriter()
        {

        }

        protected override void OnEventCommand(EventCommandEventArgs command)        
            => term.inform($"Received the {command.Command} command");    

        void Pulse(ulong EventKind, uint ServerId, uint AgentId, ulong Timestamp)
            => WriteEvent(1, EventKind, ServerId, AgentId, Timestamp);    
        
        void AgentTransitioned(ulong EventKind, uint ServerId, uint AgentId, ulong Timestamp, byte[] Body)
            => WriteEvent(2, EventKind, ServerId, AgentId, Timestamp, Body);

        /// <summary>
        /// Writes a system heartbeat event
        /// </summary>
        /// <param name="e">The event to write</param>    
        public void Receive(PulseEvent e)
            => Pulse(e.Identity.EventKind, e.Identity.ServerId, e.Identity.AgentId, e.Identity.Timestamp);

        void IAgentEventSink.AgentTransitioned(AgentTransition data)        
            => AgentTransitioned(2, data.Agent.ServerId, data.Agent.AgentId, data.Timestamp, BitConvert.bytes(data).ToArray());               
    }

    public sealed class AgentTransitioned : TraceEventAdapter<AgentTransitioned,AgentTransition>
    {

    }

    public sealed class PulseAdapter : TraceEventAdapter<PulseAdapter>
    {


    }
}