//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Events
{
    using System;

    /// <summary>
    ///   An event listener that will print all telemetry messages to the console with timestamps.
    ///   The format of the message is designed for completeness and parsability, but not for beauty.
    /// </summary>
    public class DiagnosticConsoleEventListener : EventListener
    {
        public DiagnosticConsoleEventListener(EventLevel maxVerbosity, EventKeys keywordFilter, IEventListenerEventSink eventSink)
            : base(maxVerbosity, keywordFilter, eventSink)
        {
        }

        protected override void RecordMessageInternal(TraceEventMessage message)
        {
            Console.WriteLine(this.GetLogString(message.EventName, message.Opcode, message.Payload));
        }
    }
}
