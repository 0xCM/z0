//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [Record(TableId)]
    public struct EventLogEntry : IRecord<EventLogEntry>
    {
        public const string TableId = "events";

        public string Identifier;

        public Timestamp Time;

        public string EventName;

        public CorrelationToken Correlation;

        public EventLevel Level;

        public string Source;

        public string Message;
    }
}