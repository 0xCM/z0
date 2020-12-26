//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(Kind)]
    public readonly struct RowEvent<T> : IWfEvent<RowEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Row;

        public const EventKind Kind = EventKind.Row;

        public WfEventId EventId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public RowEvent(T data)
        {
            EventId = EventName;
            Payload = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Payload.Format();
    }
}