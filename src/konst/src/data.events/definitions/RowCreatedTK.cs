//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [Event(EventName)]
    public readonly struct RowCreatedEvent<T,K> : IWfEvent<RowCreatedEvent<T,K>>
        where T : ITextual
        where K : unmanaged
    {
        public const string EventName = GlobalEvents.RowCreated;

        public Type DataType {get;}

        public Kind<K> DataKind {get;}

        public WfEventId EventId {get;}

        public T Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RowCreatedEvent(T data, K kind, CorrelationToken ct, FlairKind flair = FlairKind.DataRow)
        {
            DataType = typeof(T);
            DataKind = kind;
            EventId = (text.format("{0}/{1}", DataKind, DataType.Name), ct);
            Content = data;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Content);
    }
}