//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct EventLogEntry : IRecord<EventLogEntry>
    {
        public const string TableId = "events";

        public string Identifier;

        public Timestamp Time;

        public string EventName;

        public EventLevel Level;

        public string Source;

        public string Message;
    }
}