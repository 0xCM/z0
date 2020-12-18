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
    public readonly struct RowsEvent<T,K> : IWfEvent<RowsEvent<T,K>>
        where T : ITextual
        where K : unmanaged
    {
        public const string EventName = GlobalEvents.Rows;

        public Type DataType {get;}

        public Kind<K> DataKind {get;}

        public WfEventId EventId {get;}

        public T Content {get;}

        public FlairKind Flair => FlairKind.Data;

        [MethodImpl(Inline)]
        public RowsEvent(T data, K kind)
        {
            DataType = typeof(T);
            DataKind = kind;
            EventId = (text.format("{0}:{1}", DataKind, DataType.Name), CorrelationToken.Empty);
            Content = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}:{1}");
    }
}