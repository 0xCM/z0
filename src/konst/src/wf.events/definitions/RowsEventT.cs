//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(EventName)]
    public readonly struct RowsEvent<T> : IWfEvent<RowsEvent<T>,T>
        where T : ITextual
    {
        public const string EventName = GlobalEvents.Rows;

        public WfEventId EventId {get;}

        public Type DataType {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Data;

        [MethodImpl(Inline)]
        public RowsEvent(T data)
        {
            DataType = typeof(T);
            EventId = DataType;
            Payload = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Payload.Format();
    }
}